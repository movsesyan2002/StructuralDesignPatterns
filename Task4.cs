// You are building a Document Editor where users can format text dynamically.
// Each text document starts plain.
//  Users can add formatting layers like:
// Bold

// Italic

// Underline

// Highlight

// ✅ You must use Decorator Pattern to add these formats dynamically.

// ✅ You must not create a separate subclass for each combination of formats.
// ✅ Each format must wrap the document or another formatted document.

// 🛠 Tasks:
// Define an interface Document:

// getContent(): string

// Create a concrete class PlainTextDocument.

// Create decorator classes:

// BoldDecorator

// ItalicDecorator

// UnderlineDecorator

// HighlightDecorator

// Each decorator should:
// Implement Document interface.

// Wrap another Document.

// Modify the getContent() result to apply formatting.


using System.Reflection.Metadata.Ecma335;

interface IDocument {

    string GetContent();

}

class PlainTextDocument : IDocument{ 
    public string Content { get; set; }

    public PlainTextDocument (string content) {
        Content = content;
    }

    public string GetContent() { return Content; }
}

class BoldDecorator : IDocument {

    private IDocument _wrapper;


    public BoldDecorator (IDocument document)  { 
        _wrapper = document;
    }
    
    public string GetContent () {
    
        return $"<BOLD> {_wrapper.GetContent()} </BOLD>";
    
    }

}



class ItalicDecorator : IDocument {

    private IDocument _wrapper;


    public ItalicDecorator (IDocument document)  { 
        _wrapper = document;
    }
    
    public string GetContent () {
    
        return $"<ItalicDecorator> {_wrapper.GetContent()} </ItalicDecorator>";
    
    }

}

class UnderlineDecorator : IDocument {

    private IDocument _wrapper;


    public UnderlineDecorator (IDocument document)  { 
        _wrapper = document;
    }
    
    public string GetContent () {
    
        return $"<UnderlineDecorator> {_wrapper.GetContent()} </UnderlineDecorator>";
    
    }

}

class HighlightDecorator : IDocument {

    private IDocument _wrapper;


    public HighlightDecorator(IDocument document)  { 
        _wrapper = document;
    }
    
    public string GetContent () {
    
        return $"<HighlightDecorator> {_wrapper.GetContent()} </HighlightDecorator>";
    
    }

}