/*  GNU General Public License
  
    Droplet evaporation analyzer is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Droplet evaporation analyzer is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with Droplet evaporation analyzer.  If not, see <http://www.gnu.org/licenses/>.
*/

/*  Author:
    Jakob Berg Johansen
    Research Assistant at the Technical University of Denmark
    jajoh@byg.dtu.dk
 
    Copyright (c) 2015 Jakob Berg Johansen 
    under GNU GPL license
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


using DotNumerics.ODE;

namespace Droplet_Evaporation_Analyzer
{
    public partial class Form1 : Form
    {
        /******************Declaring variables**************/

        private int solLength;
        private double[] tValues = new double[1024];
        private double[] d_pValues = new double[1024];
        private double[] t_dValues = new double[1024];
        private double[] p_infValues = new double[1024];
        private double[] T_infValues = new double[1024];
        private double[] d_pValues_mum = new double[1024];
        private double d_p_i = new double();
        private double T_inf_i = new double();
        private double phi_inf_i = new double();
        private double p_inf_i = new double();
        private double T_d_i = new double();
        private int multi = new int();
        private double[,] sol;

        public Form1()
        {
            // Sets the culture to English (US) (using System.Threading; and System.Globalization;)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            // Sets the UI culture to English (US)
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();
        }

        private void button_Run_Click(object sender, EventArgs e)
        {
            /***************** Defining initial conditions **************/

            d_p_i = Convert.ToDouble(textBox_d_p_i.Text) * Math.Pow(10, -6);     // Initial droplet diameter [m]:
            T_d_i = Convert.ToDouble(textBox_T_d_i.Text);                        // Initial temperature of the droplet [K]:
            T_inf_i = Convert.ToDouble(textBox_T_inf_i.Text);                    // Initial temperature of the surrounding air [K]:
            phi_inf_i = Convert.ToDouble(textBox_phi_inf_i.Text);                // Initial relative humidity of surrounding air [RH]:
            double V_a = Convert.ToDouble(textBox_V_a.Text) * Math.Pow(10, -3);  // Volume flow rate of air [m^3/s]:
            double V_w = Convert.ToDouble(textBox_V_w.Text) * Math.Pow(10, -6);  // Volume flow rate of water [m^3/s]:
            double tf = Convert.ToDouble(textBox_tf.Text);                       // Evaluation time
            double delta_t = Convert.ToDouble(textBox_delta_t.Text);             // Time step


            /***************** Calculation of initial water vapour pressure **************/

            // Saturation pressure calculation (2007, P.T. Tsilingiris) [Pa]:

            double p_s_i = (0.7073
                            - 2.7036E-2 * (T_inf_i - 273.15)
                            + 4.3609E-3 * Math.Pow(T_inf_i - 273.15, 2)
                            - 4.6626E-5 * Math.Pow(T_inf_i - 273.15, 3)
                            + 1.0347E-6 * Math.Pow(T_inf_i - 273.15, 4)
                             ) * Math.Pow(10, 3);

            p_inf_i = phi_inf_i * p_s_i / 100;      // Initial water vapour pressure in the surrounding air [Pa]: 

            /***************ODE Solver*********************/

            OdeFunction YDot = new OdeFunction(Equation);
            OdeImplicitRungeKutta5 rungeKutta = new OdeImplicitRungeKutta5(YDot, 4);



            double[] y0 = new double[4];
            y0[0] = d_p_i;
            y0[1] = T_d_i;
            y0[2] = p_inf_i;
            y0[3] = T_inf_i;

            double x0 = 0;
            double xf = tf;


            /**************Solution out********************/





            /*************Error handler*********************/

            this.label_Error.Text = "Error: no error";

            try
            {
                sol = rungeKutta.Solve(y0, x0, delta_t, xf);

            }
            catch
            {
                this.label_Error.Text = "Error: Droplet evaporated";
            }

            /***************Printing number of datapoints**********/

            solLength = sol.GetLength(0);

            string input1 = solLength.ToString();
            this.textBox_number_of_data_points.Text = "";
            this.textBox_number_of_data_points.Text = input1;

            
            /*********************Converting data*******************/

            //Creating arrays to store datapoints
            tValues = new double[solLength];
            d_pValues = new double[solLength];
            t_dValues = new double[solLength];
            p_infValues = new double[solLength];
            T_infValues = new double[solLength];

            //Storing datapoints in arrays
            for (int i = 0; i < solLength; i++)
            {
                tValues[i] = sol[i, 0];
                d_pValues[i] = sol[i, 1];
                t_dValues[i] = sol[i, 2];
                p_infValues[i] = sol[i, 3];
                T_infValues[i] = sol[i, 4];
            }

            //Claculating evaporation percentage
            double evaporation = 100
                                    - ((4 / 3 * Math.PI
                                    * Math.Pow((d_pValues[solLength - 1] * Math.Pow(10, 6)) / 2, 3))
                                    / (4 / 3 * Math.PI
                                    * Math.Pow((d_p_i * Math.Pow(10, 6)) / 2, 3)) * 100);


            // Data with two decimal points
            double d_p_end = Math.Truncate(d_pValues[solLength - 1] * Math.Pow(10, 8)) / 100;
            double t_d_end = Math.Truncate(t_dValues[solLength - 1] * 100) / 100;
            double T_inf_end = Math.Truncate(T_infValues[solLength - 1] * 100) / 100;
            double p_inf_end = Math.Truncate(p_infValues[solLength - 1] * 100) / 100;
            double evap_end = Math.Truncate(evaporation * 100) / 100;

            // Printing end result
            string d_p_end_str = d_p_end.ToString();
            string t_d_end_str = t_d_end.ToString();
            string T_inf_end_str = T_inf_end.ToString();
            string p_inf_end_str = p_inf_end.ToString();
            string evap_end_str = evap_end.ToString();

            this.textBox_d_p_end.Text = "";
            this.textBox_d_p_end.Text = d_p_end_str;
            this.textBox_T_d_end.Text = "";
            this.textBox_T_d_end.Text = t_d_end_str;
            this.textBox_T_inf_end.Text = "";
            this.textBox_T_inf_end.Text = T_inf_end_str;
            this.textBox_p_inf_end.Text = "";
            this.textBox_p_inf_end.Text = p_inf_end_str;
            this.textBox_evap_end.Text = "";
            this.textBox_evap_end.Text = evap_end_str;

        }

        
        
        
        /***************Defining the Droplet evaporation equations******************/

        public double[] Equation(double T, double[] Y)
        {
            /************Initial values*************************/
            double d_p_i = Convert.ToDouble(textBox_d_p_i.Text) * Math.Pow(10, -6);
            double V_w = Convert.ToDouble(textBox_V_w.Text) * Math.Pow(10, -6);
            double V_a = Convert.ToDouble(textBox_V_a.Text) * Math.Pow(10, -3);


            /************Constants******************************/
           
            double M_w = 18.015;        //The molar mass of water [kg/kmol]
            double R_u = 8314;          //The universal gas constant [J/(kmol*K)]:
            double sigma_w = 0.072;     //Surface tention of water [N/m]:
            double lambda = 0.7E-7;     //The mean free path of the surrounding air [m]
            double alpha_h = 0.7;       //The thermal accmodation coefficient (1999, Raymond A. Shaw et al)
            double alpha_m = 0.1;       //The mass accmodation coefficient (undetermined between three orders of 
                                        //magnitude in the literature (2004, P. Davidovits)
            double C_p_w = 4.183;       //Specific heat capacity of water (293.15 K) [kJ/(kg*K]:
            double h_w = 2257;          // The latent heat of evaporation of water [kJ/kg]
            double p_0 = 101325;        // The ambiant pressure [Pa]
            double M_a = 28.97;         // The molar mass of dry air [kg/kmol]
            double Z = 1;               // Corpresibility factor for air at 1 atm
            double C_p_wv = 1.864;      // Specific heat capacity of water vapour (300 K) [kJ/(kg*K]:


            /************Variables******************************/

            // Diffusion coefficient of water vapour (Validity T_inf < 353.15) [m^2/s]:
            double D_w = -2.775E-6
                            + 4.479E-8 * Y[3]
                            + 1.656E-10 * Math.Pow(Y[3], 2);

            // Density of water [kg/m^3]:
            double rho_w = 1000
                            - 0.0067 * Math.Pow((Y[1] - 273.15) - 3.98, 2)
                            + 5.2E-7 * Math.Pow((Y[1] - 273.15) - 3.98, 4);

            // Saturation pressure calculation (2007, P.T. Tsilingiris) [Pa]:
            double p_s = (0.7073
                            - 2.7036E-2 * (Y[3] - 273.15)
                            + 4.3609E-3 * Math.Pow(Y[3] - 273.15, 2)
                            - 4.6626E-5 * Math.Pow(Y[3] - 273.15, 3)
                            + 1.0347E-6 * Math.Pow(Y[3] - 273.15, 4)
                             ) * Math.Pow(10, 3);

            double phi_inf = (Y[2] / p_s) * 100;                 // Relative humidity

            // Partial pressure of water vapour at droplet surface [Pa]:
            double p_d = p_s * Math.Exp((4 * sigma_w * M_w) / (rho_w * R_u * Y[1] * Y[0]));


            // Knudsen number [-]:
            double Kn = 2 * lambda / Y[0];


            // Correction factor for mass transfer [-]:
            double C_m = (1 + Kn) / (1 + (4 / (3 * alpha_m) + 0.377) * Kn + 4 / (3 * alpha_m) * Kn * Kn);

            // Correction factor for heat transfer [-]:
            double C_h = (1 + Kn) / (1 + (4 / (3 * alpha_h) + 0.377) * Kn + 4 / (3 * alpha_h) * Kn * Kn);


            // Thermal conductivity of dry air.
            double k_f_A = 2.4370E-2
                            + 7.8303E-5 * (Y[3] - 273.15)
                            - 3.2340E-7 * Math.Pow(Y[3] - 273.15, 2)
                            + 2.5950E-9 * Math.Pow(Y[3] - 273.15, 3)
                            - 3.1765E-12 * Math.Pow(Y[3] - 273.15, 4);

            // Thermal conductivity of saturated air.

            double k_f_V = 1.7482E-2
                            + 7.6913E-5 * (Y[3] - 273.15)
                            - 3.2346E-7 * Math.Pow(Y[3] - 273.15, 2)
                            + 2.5952E-9 * Math.Pow(Y[3] - 273.15, 3)
                            - 3.1765E-12 * Math.Pow(Y[3] - 273.15, 4);

            // Interpolated thermal conductivity of humid air used in the subsequent equations.
            double k_f = (k_f_V - k_f_A) / 100 * phi_inf + k_f_A;

            // Droplet number concentration:
            double N_d = (6 * V_w) / (3.1415 * Math.Pow(d_p_i, 3) * V_a);

            // Density of the sorrunding air [kg/m^3]:
            double rho_inf = (p_0 * M_a / (Z * (R_u / 1000) * (Y[3]))
                                * (1 - (Y[2] / p_0) * (1 - (M_w / M_a))))
                                * Math.Pow(10, -3);

            // Specific heat capacity of surrounding air [kJ/(kg*K]:
            // http://www.engineeringtoolbox.com/humidity-ratio-air-d_686.html
            double C_p_inf = 1.01 + 1.84 * (0.62198 * (phi_inf / (p_0 - phi_inf)));




            /************Equation*******************************/

            double[] ydot = new double[4];
            ydot[0] = (4 * D_w * M_w) / (rho_w * Y[0] * R_u)
                        * (Y[2] / Y[3] - p_d / Y[1]) * C_m;

            ydot[1] = -(12 / (rho_w * Math.Pow(Y[0], 2) * C_p_w))
                        * (((D_w * M_w * h_w) / R_u)
                        * (p_d / Y[1] - Y[2] / Y[3])
                        * C_m + k_f * C_h * (Y[1] - Y[3]));

            ydot[2] = -(rho_w * Math.PI * Math.Pow(Y[0], 2)
                        * N_d * R_u * Y[3] / (2 * M_w))
                        * (4 * D_w * M_w) / (rho_w * Y[0] * R_u)
                        * (Y[2] / Y[3] - p_d / Y[1]) * C_m;

            ydot[3] = Math.PI * Y[0] * N_d * (Y[3] - Y[1]) / (2 * rho_inf * C_p_inf)
                        * (rho_w * Y[0] * ((4 * D_w * M_w) / (rho_w * Y[0] * R_u)
                        * (Y[2] / Y[3] - p_d / Y[1]) * C_m) * C_p_wv - 4 * k_f * C_h);

            return ydot;

        }

        /****************Exit botton*****************/

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
