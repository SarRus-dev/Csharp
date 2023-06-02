namespace HocVien{
    public class HocVien
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Birthday { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Class { get; set; }
        public string? Note { get; set; }
        public string? Statuts { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {MiddleName} {LastName}".Trim();
            }
        }
        public HocVien() { }
        public static HocVien themHocsinh()
        {
            HocVien hocvien = new HocVien();
            Console.WriteLine("==================================================\n");
            Console.WriteLine(" NEW STUDENT\n");
            Console.WriteLine("==================================================\n");
            Console.Write("Student ID: ");
            hocvien.Id = int.Parse(Console.ReadLine() ?? "");
            Console.Write("First Name: ");
            hocvien.FirstName = Console.ReadLine();
            Console.Write("Middle Name: ");
            hocvien.MiddleName = Console.ReadLine();
            Console.Write("Last Name: ");
            hocvien.LastName = Console.ReadLine();
            Console.Write("Birthayday: ");
            hocvien.Birthday = Console.ReadLine();
            Console.Write("Address: ");
            hocvien.Address = Console.ReadLine();
            Console.Write("Phone: ");
            hocvien.Phone = Console.ReadLine();
            Console.Write("Email: ");
            hocvien.Email = Console.ReadLine();
            Console.Write("Class: ");
            hocvien.Class = Console.ReadLine();
            Console.Write("Note: ");
            hocvien.Note = Console.ReadLine();
            Console.Write("Select Status: ");
            // do
            // {
            //     int chonStatus = int.Parse(Console.ReadLine()??"");
            //     switch (chonStatus)
            //     {
            //         case 1:
            //             hocvien.Statuts = "Studying";
            //             break;
            //         case 2:
            //             hocvien.Statuts = "Reserve";
            //             break;
            //         case 3:
            //             hocvien.Statuts = "Suspended";
            //             break;
            //         case 4:
            //             hocvien.Statuts = "Dropout";
            //             break;
            //         case 5:
            //             hocvien.Statuts = "Graduated";
            //             break;
            //         default:
            //         break;
            //     }
            // } while (true);
            hocvien.Statuts = Console.ReadLine();
            return hocvien;
        }
        public static void saveSt(List<HocVien> hv){
            do
            {
                hv.Add(HocVien.themHocsinh());
                Console.WriteLine("==================================================\n");
                Console.WriteLine("Add Student Comlete! \n");
                Console.WriteLine("Do you want to continue? (Y/N): ");
                string st = Console.ReadLine() ?? "";
                if (st.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            } while (true);
        }
    }
}