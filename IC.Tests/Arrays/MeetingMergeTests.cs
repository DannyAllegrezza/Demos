using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IC.Tests.Arrays
{
    [TestClass]
    public class MeetingMergeTests
    {
        [TestMethod]
        public void TestMergeIsValid()
        {
            Meeting[] meetings = new Meeting[]
            {
                new Meeting(3,5),
                new Meeting(0,1),
                new Meeting(4,8),
                new Meeting(9,10),
                new Meeting(10,12)
            };

            var results = Meeting.GetAllAvailableTime(meetings);
        }
    }

    public class Meeting
    {
        public int StartTime { get; }

        public int EndTime { get; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }

        public static Meeting[] GetAllAvailableTime(Meeting[] meetings)
        {
            // take the initial hit to sort them
            List<Meeting> sortedMeetings = meetings.OrderBy(m => m.StartTime).ToList();

            // Initalize our new list with earliest meeting
            List<Meeting> mergedMeetings = new List<Meeting> { sortedMeetings[0] };

            foreach (var currentMeeting in sortedMeetings)
            {
                var lastMergedMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    lastMergedMeeting = new Meeting(lastMergedMeeting.StartTime,
                        Math.Max(lastMergedMeeting.EndTime, currentMeeting.EndTime));
                    mergedMeetings[mergedMeetings.Count - 1] = lastMergedMeeting;
                } else
                {
                    // Add the current meeting, which doesn't overlap with anything
                    mergedMeetings.Add(currentMeeting);
                }
            }

            return mergedMeetings.ToArray();
        }

        private Meeting MergeMeetings(Meeting first, Meeting last)
        {
            Meeting mergedMeeting = new Meeting(first.StartTime, first.EndTime);



            if (first.EndTime >= last.StartTime)
            {

            }
            return null;
        }
    }
}
