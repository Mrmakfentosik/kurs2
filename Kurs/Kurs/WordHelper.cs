using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;
namespace Kurs
{
    class WordHelper
    {
        private FileInfo _filInfo;
       
        public WordHelper()
        {
        }

        public WordHelper(string filename)
        {
            if (File.Exists(filename))

            {
                _filInfo = new FileInfo(filename);
            }
            else
            {
                throw new ArgumentException("File not found!");
            }

        }

        internal bool Procces(Dictionary<string, string> items)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _filInfo.FullName;

                Object missing = Type.Missing;

                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;


                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);

                }

                object newFileName = Path.Combine(_filInfo.DirectoryName, DateTime.Now.ToString("dd.MM") + " " + _filInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);

                app.ActiveDocument.Close();


                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if (app != null)
                {
                    app.Quit();
                }

            }
            return false;
        }
    }
}
