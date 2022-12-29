using System.Diagnostics;
using System.Runtime.InteropServices;
string url = "https://www.youtube.com/watch?v=KDb6YOokmcw";

try
{
    Process.Start(url);
}
catch
{
    // hack because of this: https://github.com/dotnet/corefx/issues/10361
    url = url.Replace("&", "^&");
    Process.Start(new ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });

}