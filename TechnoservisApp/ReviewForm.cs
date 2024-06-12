using QRCoder;

namespace TechnoservisApp
{
    public partial class ReviewForm : Form
    {
        public ReviewForm()
        {
            InitializeComponent();
            QRCode code = new QRCode(QRCodeGenerator.GenerateQrCode("", QRCodeGenerator.ECCLevel.M));
            pictureBoxCode.Image = new Bitmap(code.GetGraphic(50), pictureBoxCode.Width, pictureBoxCode.Height);
        }
    }
}
