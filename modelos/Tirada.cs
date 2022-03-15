namespace examen1.modelos
{
    public class Tirada
    {
        public int dado1;
        public int dado2;
        Random r = new Random();

        public Tirada (){    
            this.dado1 = r.Next(1, 6);
            this.dado2 = r.Next(1, 6);
        }

        public override string ToString(){
            return $"[{dado1},{dado2}]";
        }
    }
}