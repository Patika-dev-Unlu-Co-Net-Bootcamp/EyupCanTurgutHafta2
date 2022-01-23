using System;

namespace UnluCoBootCamp.Odev1.Api.Models
{
    public abstract class Animal
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public string Tur { get; set; }

        public string KlubeNo { get; set; }

        public abstract void Feed();

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    public class Kedi : Animal,IPlayToy
    {
        public override void Feed()
        {
            
        }

        public void Play()
        {
            //throw new NotImplementedException();
        }
    }

    public interface IPlayToy
    {
        void Play();
    }
}
