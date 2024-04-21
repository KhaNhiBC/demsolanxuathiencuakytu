public class Demkytu
{
    public static void demkytu(string chuoi)
    {
        int n = chuoi.Length;
        Boolean Flag = true;
        for (int i = 0; i < n;i++)
        {
            int count = 0;
            for (int j = 0;j < n;j++ )
            {
                if (chuoi[j] == chuoi[i])
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                Console.WriteLine("Ky tu {0} da xuat hien {1} lan !",chuoi[i],count);
                Flag = false;
            }

        }
        if (Flag == true){
            Console.WriteLine("Cac ky tu ban vua nhap khong co ky tu trung nhau !!!");
        }
        
    }
}