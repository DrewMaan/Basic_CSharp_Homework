using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace TrueFalse
{
	public class TrueFalseClass
	{
		string fileName;
		List<Question> questions;
		public string FileName
		{
			set { fileName = value; }
		}

		public TrueFalseClass(string fileName)
		{
			this.fileName = fileName;
			questions = new List<Question>();
		}

		public void Add(string text, bool trueFalse)
		{
			questions.Add(new Question(text, trueFalse));
		}

		public void Remove(int index)
		{
			if(questions != null && index < questions.Count && index >= 0)
			{
				questions.RemoveAt(index);
			}
		}

		public Question this[int index]
		{
			get { return questions[index]; }
		}

		public void Save()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fileStream, questions);
			fileStream.Close();
		}

		public void Save(string newFileName)
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fileStream = new FileStream(newFileName, FileMode.Create, FileAccess.Write);
			xmlFormat.Serialize(fileStream, questions);
			fileStream.Close();
		}

		public int Count
		{
			get { return questions.Count; }
		}

		public void Load()
		{
			XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
			Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			questions = (List<Question>)xmlFormat.Deserialize(fStream);
			fStream.Close();
		}
	}
}
