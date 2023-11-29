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

            //public FixtureWater[] myWaterFixtures = new FixtureWater[3];

            MyProject.FountainProjectBegin();



        }

        void OnClick(object sender, RoutedEventArgs e)
        {

            //FIXME  All this happens in response to user action; it needs to go under OnClick (at least provisionally)

            //TODO Call classes within this for() loop.
            for (int i = 0; i < MyProject.myWaterFixtures.Length; i++)
            {
                string Type = "";
                string Size = "";
                byte EffectHeight = 0;
                byte quantity = 1;

                for (int j = 0; j < NameControls.Length; j++)
                {
                    string controlName = NameControls[j];
                    dynamic MyControl = FindName(controlName);

                    if (controlName.Contains(Convert.ToString(i+1) + "_NozzleType"))
                        { Type = MyControl.Text; }

                    else if (controlName.Contains(Convert.ToString(i+1) + "_NozzleSize"))
                        { Size = MyControl.Text; }

                    else if (controlName.Contains(Convert.ToString(i+1) + "_EffectHeight"))
                        { EffectHeight = Convert.ToByte(MyControl.Text); }


                }
                if (Type != "")
                {
                    MyProject.myWaterFixtures[i] = new FixtureWaterJet(Type, Size, EffectHeight, inWeight: 3);
                }
                
            }

            int systemTotalPressure = MyProject.getTotalPressure();
            resultPSI.Text = Convert.ToString(systemTotalPressure);
        }
    }
}