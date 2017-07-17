using System;
using System.Threading.Tasks;
using Windows.Media.SpeechRecognition;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GolosApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {


        public MainPage()
        {
            this.InitializeComponent();
            //setup layout
            MainText.Width = this.Width;
            SubText.Width = this.Width;
            //setup listener

            Start();
        }

        public void Start()
        {
            MainText.Text = "Waiting for input...";
            SubText.Text = "Sum Subtext for ya boy";

            //main loop
            while(true) //TODO replace with kill
            {
                // keep listening
                if (WakeUp())
                {
                    var voiceResult = RecordToString();
                    //   MainText.Text = "Awake"
                    //   SubText.Text = "say something..."
                }
            }
        }

        private bool WakeUp()
        {
            throw new NotImplementedException();
        }

        // Ref.1  Method to convert speech to a string
        async Task<string> RecordToString()
        {
            string returnText = string.Empty;

            using (SpeechRecognizer recognizer = new SpeechRecognizer())
            {
                await recognizer.CompileConstraintsAsync();
                SpeechRecognitionResult result = await recognizer.RecognizeAsync();

                if (result.Status == SpeechRecognitionResultStatus.Success)
                {
                    returnText = result.Text;
                }
                else
                {
                    throw new Exception("Unable to convert speech to string.");
                }
                return returnText;
            }
        }
    }
}
/** References
 * 1. https://blogs.windows.com/buildingapps/2016/05/16/using-speech-in-your-uwp-apps-its-good-to-talk/#XKMW94prd00CXZYs.97
 * 
 * 
 */
