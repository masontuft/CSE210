public class MathAssignment : Assignment
{
    private string _textbookChapter;
    private string _questions;

    public MathAssignment( string name, string topic, string textbookChapter, string questions)
    : base(name, topic)
    {
        _textbookChapter = textbookChapter;
        _questions = questions;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookChapter} Problems {_questions}";
    }
}