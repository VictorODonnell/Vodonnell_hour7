using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    void Start()
    {
        // Birthday month and day
        int birthdayMonth = 2; // Example: January
        int birthdayDay = 10; // Example: 15th
        
        // Output the months in number format
        for (int i = 1; i <= 12; i++)
        {
            if (i == birthdayMonth)
            {
                Debug.Log("It's my birthday month!"); // Output if it's the birthday month
            }
            else
            {
                Debug.Log("Month: " + i); // Output the month number for other months
            }
        }
        
        // Output the days of the birthday month
        for (int j = 1; j <= 31; j++) // Assuming 31 days in all months for simplicity
        {
            if (j == birthdayDay)
            {
                Debug.Log("It's my birthday!"); // Output if it's the birthday day
            }
            else
            {
                Debug.Log("Day: " + j); // Output the day number for other days
            }
        }
    }
}
