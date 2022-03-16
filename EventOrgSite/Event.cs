using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventOrgSite
{
    public class Event
    {
        string title;
        DateTime createdDate;
        DateTime deadline;
        DateTime expiryDate;
        List<Participation> participants;
        List<Option> options;
        string discription;

    }
}