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

namespace FountainDesign        //MARK Rename this using Ctrl-R, Ctrl-R
{
    public partial class MainWindow : Window
    {

        FountainProject MyProject;
        public MainWindow()
        {
            InitializeComponent();

            MyProject = new FountainProject();

            //TODO Allow user to set MaxPressureTotal

            //public FixtureWater[] myWaterFixtures = new FixtureWater[3];

            MyProject.FountainProjectBegin();

            for (int i = 0; i < MyProject.myWaterFixtures.Length; i++)
            {
                MyProject.myWaterFixtures[i] = new FixtureWater();
            }

            MyProject.myWaterFixtures[0].Type = WaterFixture_1_NozzleType.Text;
            MyProject.myWaterFixtures[0].Size = WaterFixture_1_NozzleSize.Text;
            MyProject.myWaterFixtures[0].EffectHeight = Convert.ToByte(WaterFixture_1_EffectHeight.Text);

            MyProject.myWaterFixtures[1].Type = WaterFixture_2_NozzleType.Text;
            MyProject.myWaterFixtures[1].Size = WaterFixture_2_NozzleSize.Text;
            MyProject.myWaterFixtures[1].EffectHeight = Convert.ToByte(WaterFixture_2_EffectHeight.Text);

            MyProject.myWaterFixtures[2].Type = WaterFixture_3_NozzleType.Text;
            MyProject.myWaterFixtures[2].Size = WaterFixture_3_NozzleSize.Text;
            MyProject.myWaterFixtures[2].EffectHeight = Convert.ToByte(WaterFixture_3_EffectHeight.Text);

        }

        void OnClick(object sender, RoutedEventArgs e)
        {
            int systemTotalPressure = MyProject.getTotalPressure();
            resultPSI.Text = Convert.ToString(systemTotalPressure);
        }
    }
}