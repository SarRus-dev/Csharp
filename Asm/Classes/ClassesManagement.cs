namespace Classes{
    public class ClassManagement{
        public static string DisplayAllClass(List<Classes> cls)
        {

            foreach (Classes item in cls)
            {
                Console.WriteLine("+-------------------------------------------------------------------------------+");
                Console.WriteLine("| Class   | Study day   | Study Time           | Classroom    | Status          |");
                Console.WriteLine("+-------------------------------------------------------------------------------+");
                Console.WriteLine($"| {item.ClassName,-8}| {item.Studyday,-12}| {item.StudyTime,-21}| {item.ClassRoom,-13}| {item.Status,-16}{"|"}");
            }
            Console.WriteLine("+-------------------------------------------------------------------------------+");
            Console.WriteLine("Input Class to view Details or Input 0 back to menu: ");
            string input_cls = Console.ReadLine() ?? "";
            string back_to_menu = "0";
            foreach (Classes item in cls)
            {
                if (input_cls == item.ClassName)
                {
                    Console.WriteLine("==================================================\n");
                    Console.WriteLine(" CLASS INFPMATION");
                    Console.WriteLine("==================================================\n");
                    Console.WriteLine($"Class Name: {item.ClassName}");
                    Console.WriteLine($"Study day: {item.Studyday}");
                    Console.WriteLine($"Study time: {item.StudyTime}");
                    Console.WriteLine($"Class room: {item.ClassRoom}");
                    Console.WriteLine($"Status: {item.Status}");
                    Console.WriteLine($"Faculty: {item.Faculty}");
                }
                else if (input_cls == back_to_menu)
                {
                    break;
                }
            }
            return input_cls;
        }
        public static string closeclass(List<Classes> cls){
            string st = "Closed";
            st.Equals("closed", StringComparison.OrdinalIgnoreCase);
            string input_cls = "0";
            foreach (Classes item in cls)
            {
                if (item.Status == st)
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine("| Class   | Study day   | Study Time           | Classroom    | Status          |");
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine($"| {item.ClassName,-8}| {item.Studyday,-12}| {item.StudyTime,-21}| {item.ClassRoom,-13}| {item.Status,-16}{"|"}");
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine("Input Class to view Details or Input 0 back to menu: ");
                    input_cls = Console.ReadLine() ?? "";
                    string back_to_menu = "0";
                    if (input_cls == item.ClassName)
                    {
                        Console.WriteLine("==================================================\n");
                        Console.WriteLine(" CLASS INFPMATION");
                        Console.WriteLine("==================================================\n");
                        Console.WriteLine($"Class Name: {item.ClassName}");
                        Console.WriteLine($"Study day: {item.Studyday}");
                        Console.WriteLine($"Study time: {item.StudyTime}");
                        Console.WriteLine($"Class room: {item.ClassRoom}");
                        Console.WriteLine($"Status: {item.Status}");
                        Console.WriteLine($"Faculty: {item.Faculty}");
                        Console.WriteLine("Back to menu... ");
                        Console.ReadKey();
                    }
                    else if (input_cls == back_to_menu)
                    {
                        break;
                    }
                }
                else{
                    Console.WriteLine("No close class");
                    Console.WriteLine("Back to menu... ");
                    Console.ReadKey();
                    break;
                }
            }
            return input_cls;
        }
        public static string Comleted(List<Classes> cls)
        {
            string st = "Finish";
            st.Equals("finish", StringComparison.OrdinalIgnoreCase);
            string input_cls = "0";
            foreach (Classes item in cls)
            {
                if (item.Status == st)
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine("| Class   | Study day   | Study Time           | Classroom    | Status          |");
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine($"| {item.ClassName,-8}| {item.Studyday,-12}| {item.StudyTime,-21}| {item.ClassRoom,-13}| {item.Status,-16}{"|"}");
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine("Input Class to view Details or Input 0 back to menu: ");
                    input_cls = Console.ReadLine() ?? "";
                    string back_to_menu = "0";
                    if (input_cls == item.ClassName)
                    {
                        Console.WriteLine("==================================================\n");
                        Console.WriteLine(" CLASS INFPMATION");
                        Console.WriteLine("==================================================\n");
                        Console.WriteLine($"Class Name: {item.ClassName}");
                        Console.WriteLine($"Study day: {item.Studyday}");
                        Console.WriteLine($"Study time: {item.StudyTime}");
                        Console.WriteLine($"Class room: {item.ClassRoom}");
                        Console.WriteLine($"Status: {item.Status}");
                        Console.WriteLine($"Faculty: {item.Faculty}");
                        Console.WriteLine("Back to menu... ");
                        Console.ReadKey();
                    }
                    else if (input_cls == back_to_menu)
                    {
                        Console.WriteLine("No studying classes");
                        Console.WriteLine("Back to menu... ");
                        Console.ReadKey();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("No completed class");
                    Console.WriteLine("Back to menu... ");
                    Console.ReadKey();
                    break;
                }
            }
            return input_cls;
        }
        public static string studying(List<Classes> cl)
        {
            string st = "Studying";
            st.Equals("studying", StringComparison.OrdinalIgnoreCase);
            string input_cls = "0";
            foreach (Classes item in cl)
            {
                if (item.Status == st)
                {
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine("| Class   | Study day   | Study Time           | Classroom    | Status          |");
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine($"| {item.ClassName,-8}| {item.Studyday,-12}| {item.StudyTime,-21}| {item.ClassRoom,-13}| {item.Status,-16}{"|"}");
                    Console.WriteLine("+-------------------------------------------------------------------------------+");
                    Console.WriteLine("Input Class to view Details or Input 0 back to menu: ");
                    input_cls = Console.ReadLine() ?? "";
                    string back_to_menu = "0";
                    if (input_cls == item.ClassName)
                    {
                        Console.WriteLine("==================================================\n");
                        Console.WriteLine(" CLASS INFPMATION");
                        Console.WriteLine("==================================================\n");
                        Console.WriteLine($"Class Name: {item.ClassName}");
                        Console.WriteLine($"Study day: {item.Studyday}");
                        Console.WriteLine($"Study time: {item.StudyTime}");
                        Console.WriteLine($"Class room: {item.ClassRoom}");
                        Console.WriteLine($"Status: {item.Status}");
                        Console.WriteLine($"Faculty: {item.Faculty}");
                        Console.WriteLine("Back to menu... ");
                        Console.ReadKey();
                    }
                    else if (input_cls == back_to_menu)
                    {
                        break;
                    }
                }
                else if (item.Status == null)
                {
                    Console.WriteLine("No studying classes");
                    Console.WriteLine("Back to menu... ");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("No studying classes");
                    Console.WriteLine("Back to menu... ");
                    Console.ReadKey();
                    break;
                }
            }
            return input_cls;
        }
        public static void update_class(List<Classes> cl, string input_cls)
        {
            foreach (Classes item in cl)
            {
                if (item.ClassName == input_cls)
                {
                    Console.Write("Update Class Name: ");
                    item.ClassName = Console.ReadLine();
                    Console.Write("Update Stuyday: ");
                    item.Studyday = Console.ReadLine();
                    Console.Write("Update Study Time: ");
                    item.StudyTime = Console.ReadLine();
                    Console.Write("Update Class Room: ");
                    item.ClassRoom = Console.ReadLine();
                    Console.Write("Updatee Status (Studying, Pause, Finish, Closed): ");
                    item.Status = Console.ReadLine();
                    Console.Write("Update Faculty: ");
                    item.Faculty = Console.ReadLine();
                }
            }
        }
        public static void Change_statusClass(List<Classes> cl, string input_cls)
        {
            foreach (Classes item in cl)
            {
                if (item.ClassName == input_cls)
                {
                    Console.Write("Change Class Status: ");
                    item.Status = Console.ReadLine();
                }
            }
        }
        public static void List_Stiden(List<Classes> cl, string input_cls, List<HocVien.HocVien> hv)
        {
            foreach (Classes item in cl)
            {
                foreach (HocVien.HocVien item_hocvien in hv)
                {
                    if (item_hocvien.Class == item.ClassName)
                    {
                        Console.WriteLine("+-------------------------------------------------------------------------------+");
                        Console.WriteLine("| Student ID  | Full Names         | Class  | Phone         | Email             |");
                        Console.WriteLine("+-------------------------------------------------------------------------------+");
                        Console.WriteLine($"| {item_hocvien.Id,-12}| {item_hocvien.FullName,-19}| {item_hocvien.Class,-7}| {item_hocvien.Phone,-14}| {item_hocvien.Email,-18}{"|"}");
                        Console.WriteLine("+-------------------------------------------------------------------------------+");
                    }
                }
            }
        }
        public static int MenuS2()
        {
            Console.WriteLine("==================================================\n");
            Console.WriteLine(" ---   VTC   ACADEMY   STUDENT   MANAGEMENT   ---\n");
            Console.WriteLine("STUDENT LIST MANAGEMENT");
            Console.WriteLine("==================================================\n");
            Console.WriteLine("1. ADD  CLASS");
            Console.WriteLine("2. STUDYING CLASSES");
            Console.WriteLine("3. COMPLETED CLASSES");
            Console.WriteLine("4. CLOSED CLASSES");
            Console.WriteLine("5. ALL CLASSES");
            Console.WriteLine("6. BACK TO MAIN MENU");
            Console.WriteLine("==================================================\n");
            Console.Write("#YOUR CHOICE: ");
            int chon = int.Parse(Console.ReadLine() ?? "");
            return chon;
        }
        public static int menuso2a()
        {
            Console.WriteLine("==================================================\n");
            Console.WriteLine("  1. Update Class Information");
            Console.WriteLine("  2. Change Class Status");
            Console.WriteLine("  3. Show Student List");
            Console.WriteLine("  4. Back to ''STUDENT LIST MANAGENT''\n");
            Console.WriteLine("==================================================\n");
            Console.Write("#YOUR CHOICE: ");
            int chon = int.Parse(Console.ReadLine() ?? "");
            return chon;
        }
    }
}