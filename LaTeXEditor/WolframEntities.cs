namespace TexEditor
{
    public class WolframResult
    {
        public WolframResponse? queryresult { get; set; }
    }

    public class WolframResponse
    {
        public bool success { get; set; }
        public bool error { get; set; }
        public List<WolframPod> pods { get; set; }
    }

    public class WolframPod
    {
        public String title { get; set; }
        public List<WolframPod>? subpods { get; set; }
        public String? plaintext { get; set; }
        public WolframImage? img { get; set; }
    }

    public class WolframImage
    {
        public Uri src { get; set; }
        public String alt { get; set; }
        public String title { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }
}
