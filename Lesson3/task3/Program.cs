/*StreamReader streamReader = new StreamReader(@"C:\Users\Laptev_AR\Desktop\Конкурс\GB\GB\'testfile.txt");*/

string path = @"testfile.txt";
FileInfo dataFile= new FileInfo(path);
foreach (var line in GB.FileInfoEx.EnumLines(dataFile))
{
    string[] listOfData=line.Split('&');
    for(int i = 0; i < listOfData.Length; i++)
    {
        listOfData[i] = listOfData[i].Trim(' ');
    }  
}
/*List<string> list=ReadLine().Split("&").ToList();*/
Console.ReadKey();