Manumain menumain = new Manumain();

int chon = 0, chon1 = 0, chon1A = 0, input_id = 0;
int chon2 = 0, chon2A = 0;
string input_cls;

List<HocVien.HocVien> danh_sach = new List<HocVien.HocVien>();
List<Classes.Classes> danh_sach_class = new List<Classes.Classes>();

while (chon != 3)
{
    chon = menumain.Menuchinh();
    switch (chon)
    {
        case 1:
            do
            {
                chon1 = HocVien.SdManagement.Menuso1();
                switch (chon1)
                {
                    case 1:
                        HocVien.HocVien.saveSt(danh_sach);
                        break;
                    case 2:
                        HocVien.SdManagement.TimKiemHV(danh_sach);
                        break;
                    case 3:
                        input_id = HocVien.SdManagement.DisplayAllStudent(danh_sach);
                        do
                        {
                            chon1A = HocVien.SdManagement.menuso1a();
                            switch (chon1A)
                            {
                                case 1:
                                    HocVien.SdManagement.suathongtin(danh_sach, input_id);
                                    break;
                                case 2:
                                    HocVien.SdManagement.SuacStatus(danh_sach, input_id);
                                    break;
                                case 3:
                                    HocVien.SdManagement.Suaclass(danh_sach, input_id);
                                    break;
                                case 4:
                                    break;
                            }
                        } while (chon1A != 4);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("1->4");
                        break;
                }
            } while (chon1 != 4);
            break;
        case 2:
            do
            {
                chon2 = Classes.ClassManagement.MenuS2();
                switch (chon2)
                {
                    case 1:
                        Classes.Classes.saveCls(danh_sach_class);
                        break;
                    case 2:
                        input_cls = Classes.ClassManagement.studying(danh_sach_class);
                        do
                        {
                            chon2A = Classes.ClassManagement.menuso2a();
                            switch (chon2A)
                            {
                                case 1:
                                    Classes.ClassManagement.update_class(danh_sach_class, input_cls);
                                    break;
                                case 2:
                                    Classes.ClassManagement.Change_statusClass(danh_sach_class, input_cls);
                                    break;
                                case 3:
                                    Classes.ClassManagement.List_Stiden(danh_sach_class, input_cls, danh_sach);
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("1->4");
                                    break;
                            }
                        } while (chon2A != 4);
                        break;
                    case 3:
                        input_cls = Classes.ClassManagement.Comleted(danh_sach_class);
                        do
                        {
                            chon2A = Classes.ClassManagement.menuso2a();
                            switch (chon2A)
                            {
                                case 1:
                                    Classes.ClassManagement.update_class(danh_sach_class, input_cls);
                                    break;
                                case 2:
                                    Classes.ClassManagement.Change_statusClass(danh_sach_class, input_cls);
                                    break;
                                case 3:
                                    Classes.ClassManagement.List_Stiden(danh_sach_class, input_cls, danh_sach);
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("1->4");
                                    break;
                            }
                        } while (chon2A != 4);
                        break;
                    case 4:
                        input_cls = Classes.ClassManagement.closeclass(danh_sach_class);
                        do
                        {
                            chon2A = Classes.ClassManagement.menuso2a();
                            switch (chon2A)
                            {
                                case 1:
                                    Classes.ClassManagement.update_class(danh_sach_class, input_cls);
                                    break;
                                case 2:
                                    Classes.ClassManagement.Change_statusClass(danh_sach_class, input_cls);
                                    break;
                                case 3:
                                    Classes.ClassManagement.List_Stiden(danh_sach_class, input_cls, danh_sach);
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("1->4");
                                    break;
                            }
                        } while (chon2A != 4);
                        break;
                    case 5:
                        input_cls = Classes.ClassManagement.DisplayAllClass(danh_sach_class);
                        do
                        {
                            chon2A = Classes.ClassManagement.menuso2a();
                            switch (chon2A)
                            {
                                case 1:
                                    Classes.ClassManagement.update_class(danh_sach_class, input_cls);
                                    break;
                                case 2:
                                    Classes.ClassManagement.Change_statusClass(danh_sach_class, input_cls);
                                    break;
                                case 3:
                                    Classes.ClassManagement.List_Stiden(danh_sach_class, input_cls, danh_sach);
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("1->4");
                                    break;
                            }
                        } while (chon2A != 4);
                        break;
                    case 6:
                        break;
                    default:
                        Console.WriteLine("1 -> 6");
                        break;
                }
            } while (chon2 != 6);
            break;
        case 3:
            break;
        default:
            Console.WriteLine("1->3");
            break;
    }
}