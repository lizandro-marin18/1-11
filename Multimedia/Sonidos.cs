using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WMPLib;

namespace Multimedia
{
    public class Sonidos
    {
        public void ReproducirAlerta()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = $"1.mp3";
            player.controls.play();
            Thread.Sleep(4000);
            player.controls.stop();
        }
        public void ReproducirLLamada()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = $"2.mp3";
            player.controls.play();
            Thread.Sleep(6000);
            player.controls.stop();
        }
    }
}
