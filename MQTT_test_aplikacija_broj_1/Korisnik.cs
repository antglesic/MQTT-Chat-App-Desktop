using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT_test_aplikacija_broj_1
{
    class Korisnik
    {
        Int32 IdKorisnika { get; set; }
        string KorisnickoImeKorisnika { get; set; }
        string LozinkaKorisnika { get; set; }
        List<string> Teme;
        List<string> Poruke;

        public Korisnik()
        {

        }
        public Korisnik(Int32 id, string ime, string lozinka)
        {
            this.IdKorisnika = id;
            this.KorisnickoImeKorisnika = ime;
            this.LozinkaKorisnika = lozinka;
            this.Teme = new List<string>();
            this.Poruke = new List<string>();
        }

        public int dodajTemu(string tema)
        {
            int brojac = 0;
            bool ima = true;
            if(this.Teme.Count == 0)
            {
                this.Teme.Add(tema);
                brojac++;
            }
            else
            {
                foreach (var elem in this.Teme)
                {
                    if (elem.Equals(tema) != true)
                    {
                        ima = false;
                    }
                    else
                    {
                        ima = true;
                    }
                }
                if(ima == false)
                {
                    this.Teme.Add(tema);
                    brojac++;
                }
            }
            if (brojac > 0) return 1;
            else return 0;
        }

        public int makniTemu(string tema)
        {
            int brojac = 0;
            int hits = 0;
            if (this.Teme.Count > 0)
            {
                foreach (var elem in this.Teme)
                {
                    if (elem.Equals(tema) == true)
                    {
                        hits++;
                    }
                }
                if(hits > 0)
                {
                    this.Teme.Remove(tema);
                    brojac++;
                }
            }
            if (brojac > 0) return 1;
            else return 0;
        }

        public string[] vratiPopis()
        {
            return this.Teme.ToArray();
        }

        public int vratiBroj()
        {
            return this.Teme.Count;
        }

        public void novaPoruka(string poruka)
        {
            this.Poruke.Add(poruka);
        }

        public string[] vratiPoruke()
        {
            return this.Poruke.ToArray();
        }

        public int vratiBrojPoruka()
        {
            return this.Poruke.Count;
        }

        public string posljednjaPoruka()
        {
            return this.Poruke.Last<string>();
        }
    }
}
