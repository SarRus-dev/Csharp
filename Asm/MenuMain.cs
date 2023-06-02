
public class Manumain{
    public int Menuchinh(){
        Console.WriteLine("==================================================\n");
        Console.WriteLine(" ---   VTC   ACADEMY   STUDENT   MANAGEMENT   ---\n");
        Console.WriteLine("==================================================\n");
        Console.WriteLine("1. STUDENT LIST MANAGEMENT");
        Console.WriteLine("2. CLASSES MANAGEMENT");
        Console.WriteLine("3. EXIT APPLICATION");
        Console.WriteLine("==================================================\n");
        Console.Write("#YOUR CHOICE: ");
        int chon = int.Parse(Console.ReadLine() ?? "");
        return chon;
    }
}
