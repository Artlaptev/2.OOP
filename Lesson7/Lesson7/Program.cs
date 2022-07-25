using Task1;

ACoder Acoder=new ACoder();
BCoder BCoder=new BCoder();
string enc= Acoder.Encode("Привет Медвед");
string dec = Acoder.Decode(enc);

string enc1=BCoder.Encode("Привет Медвед");
string dec1=BCoder.Decode(enc1);
Console.ReadKey();