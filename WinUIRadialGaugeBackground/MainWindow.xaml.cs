﻿using System;
using Microsoft.UI;
using Microsoft.UI.Text;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Syncfusion.UI.Xaml.Gauges;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIRadialGaugeBackground
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            //SfRadialGauge sfRadialGauge = new SfRadialGauge();

            //RadialAxis radialAxis = new RadialAxis();
            //radialAxis.ShowAxisLine = false;
            //radialAxis.RadiusFactor = 1;
            //radialAxis.CanRotateLabels = true;
            //radialAxis.TickOffset = 0.32;
            //radialAxis.OffsetUnit = SizeUnit.Factor;
            //radialAxis.LabelPrepared += this.RadialAxis_LabelPrepared;
            //radialAxis.StartAngle = 270;
            //radialAxis.EndAngle = 270;
            //radialAxis.LabelOffset = 0.45;
            //radialAxis.Maximum = 360;
            //radialAxis.Minimum = 0;
            //radialAxis.Interval = 30;
            //radialAxis.MinorTicksPerInterval = 4;
            //radialAxis.Foreground = new SolidColorBrush(Colors.White);
            //radialAxis.FontSize = 11;
            //radialAxis.MajorTickLength = 0.087;
            //radialAxis.MinorTickLength = 0.058;
            //radialAxis.TickLengthUnit = SizeUnit.Factor;
            //radialAxis.MajorTickStyle = Application.Current.Resources["MajorTickStyle"] as Style;
            //radialAxis.MinorTickStyle = Application.Current.Resources["MinorTickStyle"] as Style;
            //BitmapImage bm = new BitmapImage();
            //bm.UriSource = new Uri("ms-appx:Images/AxisBackground.png", UriKind.Absolute);
            //Image image = new Image { Source = bm };
            //radialAxis.BackgroundContent = image;
            //sfRadialGauge.Axes.Add(radialAxis);

            //ShapePointer shapePointer = new ShapePointer();
            //shapePointer.Value = 90;
            //shapePointer.Background = new SolidColorBrush(Color.FromArgb(255, 223, 95, 45));
            //shapePointer.EnableAnimation = true;
            //shapePointer.AnimationDuration = 1200;
            //shapePointer.MarkerOffset = 0.71;
            //shapePointer.OffsetUnit = SizeUnit.Factor;
            //shapePointer.ShapeType = GaugeShapeType.Triangle;
            //shapePointer.ShapeHeight = 10;
            //shapePointer.ShapeWidth = 15;
            //radialAxis.Pointers.Add(shapePointer);

            //GaugeAnnotation gaugeAnnotation = new GaugeAnnotation();
            //gaugeAnnotation.DirectionValue = 270;
            //TextBlock textBlock = new TextBlock();
            //textBlock.Text = "90";
            //textBlock.Foreground = new SolidColorBrush(Color.FromArgb(255, 223, 95, 45));
            //textBlock.FontWeight = FontWeights.SemiBold;
            //textBlock.FontSize = 22;
            //gaugeAnnotation.Content = textBlock;
            //radialAxis.Annotations.Add(gaugeAnnotation);

            //this.Content = sfRadialGauge;
        }

        private void RadialAxis_LabelPrepared(object sender, LabelPreparedEventArgs e)
        {
            if (e.LabelText == "90")
            {
                e.LabelText = "E";
            }
            else if (e.LabelText == "360")
            {
                e.LabelText = string.Empty;
            }
            else
            {
                if (e.LabelText == "0")
                {
                    e.LabelText = "N";
                }
                else if (e.LabelText == "180")
                {
                    e.LabelText = "S";
                }
                else if (e.LabelText == "270")
                {
                    e.LabelText = "W";
                }
            }
        }
    }
}
