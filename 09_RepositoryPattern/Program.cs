using RepositoryPattern;

StreamingContent content = new StreamingContent ();
content.Title = "Arcane";
content.StarRating = 9.5;
content.MaturityRating = "PG_13";

Console.WriteLine(content.Title+ " " + content.StarRating+ " " + content.MaturityRating);

StreamingContent movie = new StreamingContent("Matrix", "What is real", 9.7, "R", false, 167);

Console.WriteLine(movie.Title + " "+ movie.StarRating);

//List<StreamingContent> listOfContent = new List<StreamingContent>();
//listOfContent.Add(content);
//listOfContent.Add(movie);

//foreach(StreamingContent streamingContent in listOfContent)
//{
//    Console.WriteLine($"Title: {streamingContent.Title} \n"+                     $"Description: {streamingContent.Description} \n");
//}
//IN THE LINE ABOVE - instead of writing two Console.WriteLines we used a \n

StreamingContentRepository repo = new StreamingContentRepository();
bool result = repo.AddContentToDirectory(movie);
Console.WriteLine($"Your content was added: {result}");

repo.AddContentToDirectory(content);

List<StreamingContent> contentInDirectory = repo.GetContents();

foreach(StreamingContent streamingContent in contentInDirectory)
{
    Console.WriteLine($"Title: {streamingContent.Title} \n"+ $"Description: {streamingContent.Description} \n");
}

StreamingContent getByTitle = repo.GetContentByTitle("Matrix");
// if you enter cw and tab, it will give the Console.WriteLine as appears below:
System.Console.WriteLine(getByTitle.RuntimeInMinutes);

// Here, we are going to update the title Arcane.  
StreamingContent updatedArcane = new StreamingContent("Arcane", "video game show with cool animation", 9.2, "PG-13", false, 52);

bool updateResult = repo.UpdateExistingContent("Arcane", updatedArcane);
Console.WriteLine($"Show updated: {updateResult}");

StreamingContent arcane = repo.GetContentByTitle("arcane");
Console.WriteLine($"Runtime: {arcane.RuntimeInMinutes}");

bool deleteResult = repo.DeleteExistingContent(arcane);
Console.WriteLine($"Was Deleted: {deleteResult}");

Console.WriteLine(repo.GetContents().Count);