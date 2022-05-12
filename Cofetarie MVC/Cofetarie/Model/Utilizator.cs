namespace Cofetarie.Model
{
    public class Utilizator
    {
        private string nume;
        private uint nrLegitimatie;
        private string cont;
        private string parola;
        private string rol;

        public Utilizator()
        {
            this.nume = "";
            this.nrLegitimatie = 0;
            this.cont = "";
            this.parola = "";
            this.rol = "";
        }

        public Utilizator(string nume, uint nrLegitimatie, string cont, string parola, string rol)
        {
            this.nume = nume;
            this.nrLegitimatie = nrLegitimatie;
            this.cont = cont;
            this.parola = parola;
            this.rol = rol;

        }

        public Utilizator(Utilizator utilizator)
        {
            this.nume = utilizator.nume;
            this.nrLegitimatie = utilizator.nrLegitimatie;
            this.cont = utilizator.cont;
            this.parola = utilizator.parola;
            this.rol = utilizator.rol;
        }

        public string GetNume()
        {
            return nume;
        }

        public uint GetNrLegitimatie()
        {
            return nrLegitimatie;
        }

        public string GetCont()
        {
            return cont;
        }

        public string GetParola()
        {
            return parola;
        }

        public string GetRol()
        {
            return rol;
        }

        public void SetNume(string nume)
        {
            this.nume = nume;
        }

        public void SetNrLegitimatie(uint nrLegitimatie)
        {
            this.nrLegitimatie = nrLegitimatie;
        }

        public void SetCont(string cont)
        {
            this.cont = cont;
        }

        public void SetParola(string parola)
        {
            this.parola = parola;
        }

        public void SetRol(string rol)
        {
            this.rol = rol;
        }

    }
}
