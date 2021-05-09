using MelonLoader;
[assembly: MelonInfo(typeof(TrackerTweak.TrackerTweak), "No Grabby Hands", "0.1", "nonce-twice")]
[assembly: MelonGame("VRChat", "VRChat")]

namespace TrackerTweak 
{
    public static class BuildInfo
    {
        public const string Name = "Tracker Tweak";
        public const string Author = "nonce-twice";
        public const string Version = "0.1";
        public const string DownloadLink = "https://github.com/nonce-twice/TrackerTweak";
    }
}
