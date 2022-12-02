using System;
using System.Security.Cryptography.X509Certificates;

namespace Applicaion
{
    public interface IStoreItem
    {
        protected double Price { get; set; }
        protected void DiscountPrice(int percent);
    }

    public class Disk : IStoreItem
    {
        protected string name;
        protected string genre;
        protected int burnCount=0;
        public double Price { get; set; }
        public virtual int DiskSize { get;}
        public virtual void Burn(params string[] values) { }
        public Disk(string name, string genre)
        {
            this.name = name;
            this.genre = genre;
        }

        public void DiscountPrice(int percent)
        {
            this.Price = Price * (100 - percent)/100;
        }
    }
    public class Audio : Disk
    {
        protected string artist;
        protected string recordingStudio;
        protected int songsNumber;
        

        public Audio(string artist, string recordingStudio, int songsNumber, string name, string genre) : base(name, genre)
        {
            this.artist = artist;
            this.recordingStudio = recordingStudio;
            this.songsNumber = songsNumber;
            this.name = name;
            this.genre = genre;
        }
        public override int DiskSize { get => this.songsNumber * 8;}
        public override void Burn(params string[] values)
        {
            this.burnCount++;
        }
        public override string ToString()
        {
            return $"Название:{name}\nЖанр: {genre}\nИсполнитель:{artist}\nСтудия: {recordingStudio}\nКоличество песен:{songsNumber}\nКоличество прожигов:{this.burnCount}";
        }
    }
 
    public class DVD : Disk
    {
        protected string producer;
        protected string filmCompany;
        protected int minutesCount;

        public DVD(string producer, string filmCompany, int minutesCount, string name, string genre) : base(name, genre)
        {
            this.producer = producer;
            this.filmCompany = filmCompany;
            this.minutesCount = minutesCount;
        }
        public override int DiskSize { get => (minutesCount / 64) * 2; }
        public override void Burn(params string[] values)
        {
            this.burnCount++;
        }
        public override string ToString()
        {
            return $"Название:{name}\nЖанр: {genre}\nРежиссер:{producer}\nКинокомпания: {filmCompany}\nКоличество минут:{minutesCount}\nКоличество прожигов:{this.burnCount}";
        }
    }
    public class Store
    {
        protected string storeName;
        protected string address;
        protected List<Audio> audios = new List<Audio>();
        protected List<DVD> dvds = new List<DVD>();
        
        public Store(string StoreName, string adress)
        {
            this.storeName = StoreName;
            this.address = adress;
        }
        public override string ToString()
        {
            string res = "Information about audios:\n";
            foreach (var audio in audios)
            {
                res += audio.ToString() + "\n\n";
            }
            res += "Information about dvds:\n";
            foreach (var dvd in dvds)
            {
                res += dvd.ToString() + "\n\n";
            }
            return res;
     
    }
        public static Store operator +(Store s, DVD a)
        {
            s.dvds.Add(a);
            return s;
        }
        public static Store operator +(Store s, Audio a)
        {
            s.audios.Add(a);
            return s;
        }
        public static Store operator -(Store s, DVD a)
        {
            s.dvds.Remove(a);
            return s;
        }
        public static Store operator -(Store s, Audio a)
        {
            s.audios.Remove(a);
            return s;
        }
    }
    public class Programm
    {
        static void Main(string[] args)
        {
            Store store = new Store("Store1", "Moscow");
            Audio a1 = new Audio("a1", "a1", 1, "a1", "a1");
            Audio a2 = new Audio("a2", "a2", 2, "a2", "a2");
            Audio a3 = new Audio("a3", "a3", 3, "a3", "a3");
            DVD d1 = new DVD("d1", "d1", 1, "d1", "d1");
            DVD d2 = new DVD("d2", "d2", 2, "d2", "d2");
            DVD d3 = new DVD("d3", "d3", 3, "d3", "d3");
            store = store + a1;
            store = store + a2;
            store = store + a3;
            store = store + d1;
            store = store + d2;
            store = store + d3;
            Console.WriteLine(store);
            d1.Burn();
            a3.Burn();  
            Console.WriteLine(store);
        }
    }
}