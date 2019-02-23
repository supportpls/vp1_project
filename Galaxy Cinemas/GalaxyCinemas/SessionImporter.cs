﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using Common;

namespace GalaxyCinemas
{
    public class SessionImporter : BaseImporter
    {
        public SessionImporter(string filename) : base(filename)
        {
        }

        /// <summary>
        /// Import session file. Filename has been provided in the constructor.
        /// </summary>
        public override void Import(object o)
        {
            // Initialise progress to zero for progress bar.
            float progress = 0f;
            ImportResult results = new ImportResult();
            try
            {
                // Read file
                string fileData = null;
                using (StreamReader reader = File.OpenText(fileName))
                {
                    fileData = reader.ReadToEnd();
                }
                string[] lines = fileData.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n'); // To deal with Windows, Mac and Linux line endings the same.
                string firstLine = lines[0];
                // Check if first line is column names.
                string[] columns = firstLine.Split(',');
				if (columns.Length==4){
					if(columns[0].ToLower().Trim()=="sessionid" 
                    && columns[1].Trim().ToLower()=="movieid"
                    && columns[1].Trim().ToLower()=="sessiondate"
                    && columns[1].Trim().ToLower()=="cinemanumber"){
						lines[0]="";}
				}
                // Line count and line numbers to allow progress tracking.
                int lineCount = lines.Length;
                int lineNum = 1;

                // Get all movies. These will be used to check that MovieIDs are valid.
                List<Movie> movies = DataLayer.DataLayer.GetAllMovies();

                foreach (string line in lines)
                {
                    // Check whether we need to stop after importing each line.
                    if (Stop)
                    {
                        return;
                    }

                    try
                    {
                        // Just to make it slow enough to testing stopping functionality.
                        Thread.Sleep(500);

                        // Update progress of import.
                        progress=lineNum/lineCount;
						RaiseProgressChanged();                  

                        // Skip blank lines
						if(String.IsNullOrEmpty(line)){
							continue;}
						else{
							results.TotalRows=results.TotalRows++;}                       

                        // Break up line by commas, each item in array will be one column.
                        columns = line.Split(',');                        
                        if (columns.Length != 4)
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: Wrong number of columns.", lineNum));
                            continue;
                        }

                        // Check the format of data, and update ImportResult accordingly.

                        // Check movie ID.
                        int movieID = 0;
                        if (!int.TryParse(columns[1].Trim(), out movieID))
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: MovieID is not a number.", lineNum));
                            continue;
                        }
                        if (movies.Count(m => m.MovieID == movieID) < 1)
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: MovieID not found in movie database.", lineNum));
                            continue;
                        }
                        // Check session date/time.
                        DateTime sessionDate = DateTime.MinValue;
                        if (!DateTime.TryParse(columns[2].Trim(), out sessionDate))
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line{0}: Session date is not a date/time", lineNum));
                            continue;
                        }

                        // Check session ID.
                        int sessionID = 0;
                        if (!int.TryParse(columns[1].Trim(), out sessionID))
                        {
                            results.FailedRows++;
                            results.ErrorMessages.Add(string.Format("Line {0}: SessionID is not a number.", lineNum));
                            continue;
                        }
                        // Check cinema number.
                        /*test comment*/
                        if ()                        







                        // Insert/update DB if okay.
                        













                        
                    }
                    catch (System.Data.Common.DbException dbEx)
                    {
                        results.FailedRows++;
                        results.ErrorMessages.Add(string.Format("Line {0}: Database error occurred updating data.", lineNum));
                    }
                    finally
                    {
                        lineNum++;
                    }
                }
            }
            catch (System.IO.IOException)
            {
                results.ErrorMessages.Add("Error occurred opening file. Please check that the file exists and that you have permissions to open it.");
            }
            catch (Exception)
            {
                results.ErrorMessages.Add("An unknown error occurred during importing.");
            }
            finally
            {
                // Do callback to end import.
                RaiseCompleted(results);
            }

        
        }

    }
}
