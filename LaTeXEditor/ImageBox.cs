namespace TexEditor
{
    public partial class ImageBox : Form
    {
        WolframPod pod;

        public ImageBox(WolframPod pod)
        {
            InitializeComponent();

            this.pod = pod;

            if (pod.img == null)
            {
                return;
            }

            pictureBox.ImageLocation = pod.img.src.ToString();
            Size = new Size(pod.img.width * 2, pod.img.height * 2);
        }

        private void copyAnswer(object sender, EventArgs e)
        {
            if (pod.plaintext == null)
            {
                return;
            }

            Clipboard.SetText(pod.plaintext);
        }
    }
}
