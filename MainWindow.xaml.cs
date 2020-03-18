using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace Predictor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand;
        int numRand;

        SpeechSynthesizer reader;

        string[] timeArray,aspectArray,effectArray,personaArray,featureArray,consequenceArray;
        public MainWindow()
        {

            timeArray = new string[] {
                "thirty minutes",
                "an hour",
                "eight hours",
                "twelve hours",
                "a day",
                "a week",
                "a month",
                "a year",
                "a decade"};

            aspectArray = new string[] { 
                "finances",
                "love life",
                "career prospects",
                "travel plans",
                "relationships"
               };

            effectArray = new string[] {
                "fall apart",
                "exceed your expectation",
                "become awkward in an unexpected way",
                "become manageable",
                "become spectacular",
                "come to a positive outcome"
            };

            personaArray = new string[] {
                "man",
                "boy",
                "woman",
                "girl",
                "dog",
                "bird",
                "hedgehog",
                "singer",
                "relative"
            };

            featureArray = new string[] {
                "pink hair",
                "a broken golden chain",
                "scary eyes",
                "long blonde nose hair",
                "very red lips",
                "silver feet"

            };

            consequenceArray = new string[] {
                "avoid looking at directly",
                "sing a sad song with",
                "stop and talk to",
                "dance with",
                "tell a secret",
                "buy a coffee"
            };


            for (int i = 0; i < timeArray.Length; i++) {
                Console.WriteLine(timeArray[i]);
            }
            InitializeComponent();

            reader = new SpeechSynthesizer();
            reader.SetOutputToDefaultAudioDevice();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            rand = new Random(DateTime.Now.Millisecond);



            //TextBlock.Text = String.Format("Over a period of {0} your {1} will {2}. " + "\n" +
            //                               "This will come to pass after you meet a {3} with {4} who for some reason you find" +
            //                               "yourself obliged to {5}",
            //                               timeArray[rand.Next(0,timeArray.Length)],
            //                               aspectArray[rand.Next(0,aspectArray.Length)],
            //                               effectArray[rand.Next(0,effectArray.Length)],
            //                               personaArray[rand.Next(0,personaArray.Length)],
            //                               featureArray[rand.Next(0,featureArray.Length)],
            //                               consequenceArray[rand.Next(0,consequenceArray.Length)]);

            TextBlock.Text = "GAAAAAAAGO";
            if (SynthesizerState.Speaking != reader.State)
            {
                // Speak a string asynchronously, text taken from the textbox.
                reader.SpeakAsync(TextBlock.Text);
            }

        }
    }
}
