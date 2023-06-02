namespace HocVien{
    public class SdManagement{
        public static void TimKiemHV(List<HocVien> tkhv)
        {
            Console.Write("Enter last name to search: ");
            string tenTimkiem = Console.ReadLine() ?? "";
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            Console.WriteLine("| Student ID  | Full Names         | Class  | Phone         | Email             |");
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            foreach (HocVien item in tkhv)
            {
                if (tenTimkiem == item.LastName)
                {
                    Console.WriteLine($"| {item.Id,-12}| {item.FullName,-19}| {item.Class,-7}| {item.Phone,-14}| {item.Email,-18}{"|"}");
                }
            }
            Console.WriteLine("+-------------------------------------------------------------------------------+");
        }
        public static void suathongtin(List<HocVien> hv, int input_id)
        {
            foreach (HocVien item in hv)
            {
                if (item.Id == input_id)
                {
                    Console.Write("Change Student ID: ");
                    item.Id = int.Parse(Console.ReadLine() ?? "");
                    Console.Write("Change First Name: ");
                    item.FirstName = Console.ReadLine();
                    Console.Write("Change Middle Name: ");
                    item.MiddleName = Console.ReadLine();
                    Console.Write("Change Last Name: ");
                    item.LastName = Console.ReadLine();
                    Console.Write("Change Birthayday: ");
                    item.Birthday = Console.ReadLine();
                    Console.Write("Change Address: ");
                    item.Address = Console.ReadLine();
                    Console.Write("Change Phone: ");
                    item.Phone = Console.ReadLine();
                    Console.Write("Change Email: ");
                    item.Email = Console.ReadLine();
                    Console.Write("Change Class: ");
                    item.Class = Console.ReadLine();
                    Console.Write("Change Note: ");
                    item.Note = Console.ReadLine();
                    Console.Write("Change Status: ");
                    item.Statuts = Console.ReadLine();
                }
            }
        }
        public static void Suaclass(List<HocVien> hv, int input_id)
        {
            foreach (HocVien item in hv)
            {
                if (item.Id == input_id)
                {
                    Console.Write("Change Class: ");
                    item.Class = Console.ReadLine();
                }
            }
        }
        public static void SuacStatus(List<HocVien> hv, int input_id)
        {
            foreach (HocVien item in hv)
            {
                if (item.Id == input_id)
                {
                    Console.Write("Change Status: ");
                    item.Statuts = Console.ReadLine();
                }
            }
        }
        public static int DisplayAllStudent(List<HocVien> hv)
        {
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            Console.WriteLine("| Student ID  | Full Names         | Class  | Phone         | Email             |");
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            foreach (HocVien item in hv)
            {
                Console.WriteLine($"| {item.Id,-12}| {item.FullName,-19}| {item.Class,-7}| {item.Phone,-14}| {item.Email,-18}{"|"}");
            }
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            Console.WriteLine("Input Student ID to view Details or input 0 back to menu: ");
            int input_id = int.Parse(Console.ReadLine() ?? "");
            foreach (HocVien item in hv)
            {
                if (input_id == item.Id)
                {
                    Console.WriteLine("==================================================\n");
                    Console.WriteLine(" STUDENT INFPMATION");
                    Console.WriteLine("==================================================\n");
                    Console.WriteLine($"Student ID: {item.Id}");
                    Console.WriteLine($"First Name: {item.FirstName}");
                    Console.WriteLine($"Middle Name: {item.MiddleName}");
                    Console.WriteLine($"Last Name: {item.LastName}");
                    Console.WriteLine($"Birthday: {item.Birthday}");
                    Console.WriteLine($"Addtess: {item.Address}");
                    Console.WriteLine($"Phone: {item.Phone}");
                    Console.WriteLine($"Email: {item.Email}");
                    Console.WriteLine($"Class Name: {item.Class}");
                    Console.WriteLine($"Note: {item.Note}");
                    Console.WriteLine($"Status: {item.Statuts}");
                }
                else if (input_id == 0 ||input_id != item.Id)
                {
                    break;
                }
                else if (input_id != 0 && input_id != item.Id)
                {
                    Console.WriteLine("Error: Input Student ID to view Details or input 0 back to menu ");
                }
            }
            Console.WriteLine("==================================================\n");
            return input_id;
        }
        public static int menuso1a()
        {
            Console.WriteLine("==================================================\n");
            Console.WriteLine("  1. Update Student Information");
            Console.WriteLine("  2. Change Student Status");
            Console.WriteLine("  3. Change Class");
            Console.WriteLine("  4. Back to ''STUDENT LIST MANAGENT''\n");
            Console.WriteLine("==================================================\n");
            Console.Write("#YOUR CHOICE: ");
            int chon = int.Parse(Console.ReadLine() ?? "");
            return chon;
        }
        public static int Menuso1()
        {
            Console.WriteLine("==================================================\n");
            Console.WriteLine(" ---   VTC   ACADEMY   STUDENT   MANAGEMENT   ---\n");
            Console.WriteLine("STUDENT LIST MANAGEMENT");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("1. ADD  STUDENT");
            Console.WriteLine("2. SEARCH STUDENT");
            Console.WriteLine("3. SHOW ALL STUDENT");
            Console.WriteLine("4. BACK TO MAIN MENU");
            Console.WriteLine("==================================================\n");
            Console.Write("#YOUR CHOICE: ");
            int chon = int.Parse(Console.ReadLine() ?? "");
            return chon;
        }
    }
}