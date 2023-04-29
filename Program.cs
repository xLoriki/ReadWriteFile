var fn = "dane.txt"; //change file directory to wherever you want else it will appear in:
                     //-debug (using project)
                     //-program directory

FileStream fs = new FileStream(fn,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.Read);
fs.Position = 0; 
//^^^ To overwrite file if something is already there, else delete and use append or read file 
// until there is no more characters and start from there

StreamWriter sw = new StreamWriter(fs);
sw.WriteLine("Jakub Soloducha | 01.11.2001");
sw.Close();

FileInfo fi = new FileInfo(fn);
StreamReader sr = fi.OpenText();
string s = "";
while ((s = sr.ReadLine()) != null)
{
    Console.WriteLine(s);
}
sr.Close();

fs.Close();