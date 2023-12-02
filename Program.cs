using System.Runtime.CompilerServices;

namespace Homework_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Blocknot blocknot = new Blocknot();

            //Console.WriteLine("1 - Add");
            //Console.WriteLine("2 - Find");
            //Console.WriteLine("3 - Show All");
            //Console.WriteLine("4 - Exit");

            //Console.WriteLine("Enter your choice");

            int i = 0;
            do
            {
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Find");
                Console.WriteLine("3 - Show All");
                Console.WriteLine("4 - Exit");

                Console.WriteLine("Enter your choice");

                if (int.TryParse(Console.ReadLine(), out i))
                {
                    switch (i)
                    {
                        case 1:
                            Record record = new Record();
                            Console.WriteLine("Please Enter Name");
                            record.Name = Console.ReadLine();
                            Console.WriteLine("Please Enter Phone Number");
                            record.Phone = Console.ReadLine();

                            blocknot.Add(record);

                            WriteDocFile(record);

                            Console.WriteLine("Succsesfully");
                            break;
                            
                        case 2:
                            Console.WriteLine("Please input Name");
                            Record foundRecord = blocknot[Console.ReadLine()];
                            if (foundRecord == null)
                                Console.WriteLine("Record not found");
                            else
                                Console.WriteLine($"Record found: {foundRecord}");
                            break;
                            
                        case 3:
                            ReadDocFile();
                            break;
                            
                        case 4:
                                Console.WriteLine("GoodBye");
                            break;
                    }
                }
            } while (i == 1 || i == 2 || i == 3);


            // Create blocknot with a few records
            //blocknot.Add(new Record("John", "123456789"));
            //blocknot.Add(new Record("Jack", "987654321"));
            //blocknot.Add(new Record("Jill", "123123123"));
            //blocknot.Add(new Record("Jane", "321321321"));

            //Record foundRecord = blocknot["Jack"];

            //WriteDocFile(blocknot.records);
            //ReadDocFile();

            //if (foundRecord == null)
            //    Console.WriteLine("Record not found");
            //else
            //    Console.WriteLine($"Record found: {foundRecord}");
        }


        private static void WriteDocFile(Record record)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\FileTest\TestingStreams.txt", true))
            {
                writer.WriteLine(record);
                
                writer.Close();
            }
        }

        private static void ReadDocFile()
        {
            FileStream stream = new FileStream(@"C:\FileTest\TestingStreams.txt", FileMode.Open, FileAccess.Read);

            StreamReader streamReader = new StreamReader(stream);

            Console.WriteLine(streamReader.ReadToEnd());
        }
    }
}