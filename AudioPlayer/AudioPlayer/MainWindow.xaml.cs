using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AudioPlayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MediaPlayer mediaPlayer;
        public MainWindow()
        {
            InitializeComponent();
            mediaPlayer = new MediaPlayer();
            mediaPlayer.Open(new Uri("C:\\Users\\user3\\Downloads\\pesnya.mp3", UriKind.Relative));
            mediaPlayer.MediaEnded += MediaPlayer_MediaEnded; 
        }
        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
           mediaPlayer.Position = TimeSpan.Zero; // Сбрасываем позицию для бесконечного воспроизведения mediaPlayer.Play();
            mediaPlayer.Play();
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Play();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mediaPlayer.Stop();
        }
    }
}