using System.Diagnostics;
using System.Net;
using System.Reflection;

namespace TexEditor
{
    public class TexWrapper
    {
        private List<String> args = new List<String>() { "/c", "pdflatex", "-quiet" };

        public string outputDir = String.Empty;
        public string fileName = String.Empty;
        public string target = String.Empty;

        private void clear()
        {
            args = new List<String>() { "/c", "pdflatex", "-quiet" };
            outputDir = String.Empty;
            fileName = String.Empty;
        }

        public void Compile()
        {
            Process p = new Process();

            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.CreateNoWindow = true;

            if (target == String.Empty)
            {
                throw new Exception("TexWrapper must have a target");
            }

            if (outputDir != String.Empty)
            {
                args.Add($"-output-directory {outputDir}");
            }

            if (fileName != String.Empty)
            {
                args.Add($"-jobname {fileName}");
            }

            args.Add(target);

            p.StartInfo.Arguments = String.Join(" ", args);
            p.Start();

            clear();
        }
    }
}
