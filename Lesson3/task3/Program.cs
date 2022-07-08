using GB;

string pathOfDataFile = @"testfile.txt";
string pathOfResultFile = @"resultfile.txt";

FileInfo dataFile= new FileInfo(pathOfDataFile);

FileStream file = new FileStream(pathOfResultFile, FileMode.Create);
StreamWriter sw = new StreamWriter(file);


foreach (string line in dataFile.EnumLines())
{
    string middleLine = line;
    Operations.GetMail(ref middleLine);
    
    sw.WriteLine(middleLine);
}
sw.Close();
file.Close();
Console.ReadKey();