//using SerialisationApp;
//using System;
//using System.IO;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace SerialisationObject
//{
//    class Program
//    {
//        const string FileName = @"../../../SavedLoan.bin";
//        static void Main(string[] args)
//        {
//            Loan TestLoan;

//            if (File.Exists(FileName))
//            {
//                Console.WriteLine("Reading saved file");
//                Stream openFileStream = File.OpenRead(FileName);
//                BinaryFormatter deserializer = new BinaryFormatter();
//                TestLoan = (Loan)deserializer.Deserialize(openFileStream);
//                openFileStream.Close();
//            }
//            else
//            {
//                TestLoan = new Loan(10000.0, 7.5, 36, "Neil Black");
//            }

//            Console.WriteLine(TestLoan.InterestRatePercent);
//            hfTestLoan.InterestRatePercent = 7.8;
//            Console.WriteLine(TestLoan.InterestRatePercent);

//            Stream SaveFileStream = File.Create(FileName);
//            BinaryFormatter serializer = new BinaryFormatter();
//            serializer.Serialize(SaveFileStream, TestLoan);
//            SaveFileStream.Close();
//        }
//    }
//}
