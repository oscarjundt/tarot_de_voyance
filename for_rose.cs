using System;
class rose{
    static void Main(){
        string[] vois = new string[]{"I. Le Bateleur","II. La Papesse","III. L’Impératrice","IIII. L’Empereur","V. Le Pape","VI. L’Amoureux","VII. Le Chariot","VIII. La Justice","VIIII. L’Hermite","X. La Roue de Fortune","XI. La Force","XII. Le Pendu","XIII. L’Arcane sans nom","XIIII. Tempérance","XV. Le Diable","XVI. La Maison Dieu","XVII. L’Étoile","XVIII. La Lune","XVIIII. Le Soleil","XX. Le Jugement","XXI. Le Monde","Le Mat"};
        int[] chiffre = new int[22];
        Random t = new Random();
        initialisation(vois,chiffre,t);
        affichage(vois,chiffre);
    }
    public static void initialisation(string[] x1, int[] x2, Random y){
        for(int i=0;i<x2.Length;i++){
            x2[i]=y.Next(22);
        }
    }
    public static void affichage(string[] x3, int[] x4){
        for(int i2=0;i2<x4.Length;i2++){
            Console.Write(i2+",");
        }
        for(int i3=0;i3<4;i3++){
            Console.WriteLine("");
            Console.Write("choisiser un nombre: ");
            int a=int.Parse(Console.ReadLine());
            int chi = x4[a];
            Console.WriteLine(x3[chi]);
        }
    }
}