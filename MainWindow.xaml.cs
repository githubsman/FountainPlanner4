using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FountainDesign;

namespace FountainDesign
{
    public partial class MainWindow : Window
    {
        string[] NameControls = {"WaterFixture_1_NozzleType", "WaterFixture_2_NozzleType", "WaterFixture_3_NozzleType",
                        "WaterFixture_1_NozzleSize", "WaterFixture_2_NozzleSize", "WaterFixture_3_NozzleSize",
                        "WaterFixture_1_EffectHeight", "WaterFixture_2_EffectHeight", "WaterFixture_3_EffectHeight",
                        "WaterFixture_1_Quantity", "WaterFixture_2_Quantity", "WaterFixture_3_Quantity"};

        FountainProject MyProject;
        public MainWindow()
        {
            InitializeComponent();

            MyProject = new FountainProject();

            //TODO Allow user to set MaxPressureTotal

            MyProject.FountainProjectBegin();



        }

        void OnClick(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < MyProject.myWaterFixtures.Length; i++)
            {
                string f_Type = "";
                string f_Size = "";
                byte quantity = 1;
                byte effectHeight = 0;

                // scan my array NameControls[] for matching controlName
                for (int j = 0; j < NameControls.Length; j++)
                {
                    string controlName = NameControls[j];
                    dynamic MyControl = FindName(controlName);

                    if (controlName.Contains(Convert.ToString(i + 1) + "_NozzleType"))
                    { f_Type = MyControl.Text; }

                    else if (controlName.Contains(Convert.ToString(i + 1) + "_NozzleSize"))
                    { f_Size = MyControl.Text; }

                    else if (controlName.Contains(Convert.ToString(i + 1) + "_EffectHeight"))
                    { effectHeight = Convert.ToByte(MyControl.Text); }

                    else if (controlName.Contains(Convert.ToString(i + 1) + "_Quantity"))
                    { quantity = Convert.ToByte(MyControl.Text); }
                }

                // choose fixture subclass based on value of "type"
                if (f_Type == "jet")
                {   MyProject.myWaterFixtures[i] = new FixtureWaterJet(f_Type, f_Size, effectHeight, inQuantity: quantity); }
                else if (f_Type == "spray")
                {   MyProject.myWaterFixtures[i] = new FixtureWaterSpray(f_Type, f_Size, effectHeight, inQuantity: quantity); }
                else if (f_Type == "mist")
                {   MyProject.myWaterFixtures[i] = new FixtureWaterMist(f_Type, f_Size, effectHeight, inQuantity: quantity); }


            }

            int systemTotalPressure = MyProject.getTotalPressure();
            resultPSI.Text = Convert.ToString(systemTotalPressure);
        }
    }
}