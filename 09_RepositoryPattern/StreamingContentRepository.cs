namespace RepositoryPattern
{
    public class StreamingContentRepository
    {
        //Field for data storage
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Retrieve it *search*, Store, Update, Delete
        //CRUD (Create (Store), Read (Retrieve), Update, Delete)

        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(content);

            bool wasAdded = startingCount < _contentDirectory.Count;
            return wasAdded;
        }

        //Read
        //ReadAll
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }
        
        //ReadSearch
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(title.ToLower() == content.Title.ToLower())
                {
                    return content;
                }
            }
            
        return null;
        }
        //Update

        //Update by Title
        public bool UpdateExistingContent(string oldTitle, StreamingContent updatedContent)
        {
            StreamingContent oldContent = GetContentByTitle(oldTitle);

            // You would think that the following code would work: oldContent = updatedContent;  
            // IT DOESN'T

            //Does the Content Exist???  If we don't get something returned, we want it to be a null value to tell us it doesn't exist.
            if(oldContent != null)
            {
                oldContent.Title = updatedContent.Title;
                oldContent.Description = updatedContent.Description;
                oldContent.StarRating = updatedContent.StarRating;
                oldContent.MaturityRating = updatedContent.MaturityRating;
                oldContent.IsFamilyFriendly = updatedContent.IsFamilyFriendly;
                oldContent.RuntimeInMinutes = updatedContent.RuntimeInMinutes;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Delete
        public bool DeleteExistingContent(StreamingContent contentToDelete)
        {
            return _contentDirectory.Remove(contentToDelete);
        }
            // DELETE BY TITLE
            public bool DeleteByTitle(string title)
            {
                StreamingContent contentToDelete = GetContentByTitle(title);
                return DeleteExistingContent(contentToDelete);
            }

    }
}