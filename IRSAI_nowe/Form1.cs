using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using rtChart;

namespace IRSAI_nowe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Plc plc = new Plc(CpuType.S7300, "192.168.1.1", 0, 2); //stworzenie obiektu reprezentującego sterownik
       
        //połączenie ze sterownikiem
        private void Button_connect_Click(object sender, EventArgs e)
        {
            plc.Open();

            plc.WriteBit(DataType.DataBlock, 2010, 4, 0, 1); //ustawia sterowanie ręczne
            plc.WriteBit(DataType.DataBlock, 2010, 4, 1, 1); //Obroty silnika zgodnie z ruchem wskazówek zegara
        }

        //Rozłączenie ze sterownikiem
        private void Button_disconnect_Click(object sender, EventArgs e)
        {
            plc.Close();
        }

        //Sprawdzenie prędkości silnika i prądu
        private void Button_Get_Click(object sender, EventArgs e)
        {
            ushort Vactual = (ushort)plc.Read("DB2010.DBW0"); //odczyt prędkości

            textBox_Vactual.Text = (Vactual / 5).ToString(); //przeskalowanie na rpm

            ushort Current = (ushort)plc.Read("DB2010.DBW8"); //odczyt prądu

            textBox_Current.Text = (Current / 1000.0).ToString(); //przeskalowanie na Ampery
        }

        //Ustawienie prędkości zadanej
        private void Button_Set_Click(object sender, EventArgs e)
        {
            string Vset_str = textBox_Vset.Text;
            ushort Vset = Convert.ToUInt16(Vset_str);
            if (manual_control.Checked == true) //ustawiamy tylko przy sterowaniu ręcznym
            {
                if (Vset > 0 && Vset < 1500)
                {
                    plc.Write("DB2010.DBW2", (short)(Vset * 5));
                }
                else if (Vset >= 1500) //zabezpieczenie żeby nie ustawić zbyt dużej prędkości
                {
                    plc.Write("DB2010.DBW2", (short)7500);
                }
            }
            else //przy sterowaniu automatycznym nic nie robimy
            {

            }
        }

        //Sprawdzenie czy sterowanie ręczne, czy automatyczne
        private void Manual_control_Checked(object sender, EventArgs e)
        {
            if (plc.IsConnected == true)
            {
                if (manual_control.Checked == true)
                {
                    plc.WriteBit(DataType.DataBlock, 2010, 4, 0, 1); //sterowanie ręczne
                }
                else
                {
                    plc.Write("DB2010.DBW2", (short)0);
                    plc.WriteBit(DataType.DataBlock, 2010, 4, 0, 0); //sterowanie automatyczne
                }
            }
        }

        //Obroty silnika zgodnie z ruchem wskazówek zegara
        private void Cw_button_Checked(object sender, EventArgs e)
        {
            if (plc.IsConnected == true)
            {
                plc.WriteBit(DataType.DataBlock, 2010, 4, 2, 0);
                plc.WriteBit(DataType.DataBlock, 2010, 4, 1, 1);
            }
        }

        //Obroty silnika przeciwnie do ruchu wskazówek zegara
        private void Ccw_button_Checked(object sender, EventArgs e)
        {
            if (plc.IsConnected == true)
            {
                plc.WriteBit(DataType.DataBlock, 2010, 4, 1, 0);
                plc.WriteBit(DataType.DataBlock, 2010, 4, 2, 1);
            }
        }

        //Rampa - czas z jakim silnik dochodzi do zadanej prędkości
        private void Button_Ramp_Click(object sender, EventArgs e)
        {
            string Ramp_str = textBox_Ramp.Text;
            ushort Ramp = Convert.ToUInt16(Ramp_str);
            if (manual_control.Checked == true) //jeśli sterowanie ręczne to można ustawić rampę
            {
                if (Ramp > 0)
                {
                    plc.Write("DB2010.DBW6", Ramp);

                    ushort Ramp2 = (ushort)plc.Read("DB2010.DBW6"); //sprawdzenie czy dobrze zadaliśmy rampę
                    textBox_Ramp_Read.Text = Ramp2.ToString();
                }
            }
        }


        /// <summary>
        /// Sekcja wykresów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Draw_Chart_Click(object sender, EventArgs e) //przycisk do rysowania wykresu
        {
            kayChart Data1 = new kayChart(chart1, 240);
            Data1.serieName = "V_actual"; //prędkość aktualna

            Task.Factory.StartNew(() =>
            {
                Data1.updateChart(update1, 250);
            });


            kayChart Data2 = new kayChart(chart1, 240); //prędkość zadana
            Data2.serieName = "V_set";

            Task.Factory.StartNew(() =>
            {
                Data2.updateChart(update2, 250);
            });
        }

        private double update1() //funkcja do pobrania prędkości aktualnej
        {
            short actuall = 7;//(short)plc.Read("DB2010.DBW0");
            return actuall;
        }

        private double update2() //funkcja do pobrania prędkości zadanej
        {
            short actuall = 10;//(short)plc.Read("DB2010.DBW2");
            return actuall;
        }
    }
}
