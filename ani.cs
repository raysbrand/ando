// Method to extract the file name from a folder path
public static string GetFileNameFromFolder(string folder)
{
    // Check if the folder path is null or empty
    if (string.IsNullOrEmpty(folder))
    {
        throw new ArgumentException("Folder path cannot be null or empty.", nameof(folder));
    }

    // Use the Path.GetFileName method to extract the file name
    string fileName = Path.GetFileName(folder);

    // Check if the file name is null or empty (which means the folder path did not contain a file name)
    if (string.IsNullOrEmpty(fileName))
    {
        throw new ArgumentException("The provided folder path does not contain a file name.", nameof(folder));
    }

    // Return the file name
    return fileName;
}
