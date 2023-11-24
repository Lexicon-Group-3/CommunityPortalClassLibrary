namespace CommunityPortalClassLibrary
{
	#region UserManagementClass
	public class UserManagement
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string AccountLevel { get; set; }

		public UserManagement(
		int userID,
		string userName,
		string userEmail,
		string userPassword,
		string userLevel)
		{
			this.Id = userID;
			this.Name = userName;
			this.Email = userEmail;
			this.Password = userPassword;
			this.AccountLevel = userLevel;
		}
	}
	#endregion

	#region FeatureClasses
	public class Forum
	{
		public int ThreadId { get; set; }
		public string ThreadName { get; set; }
		public string PostTitle { get; set; }
		public string UserId { get; set; }
		public string UserName { get; set; }
		public string UserEmail { get; set; }

		public Forum(
		int threadID,
		string threadName,
		string postTitle,
		string userId,
		string userName,
		string userEmail)
		{
			this.ThreadId = threadID;
			this.ThreadName = threadName;
			this.PostTitle = postTitle;
			this.UserId = userId;
			this.UserName = userName;
			this.UserEmail = userEmail;
		}
	}

	public class CurrentEvents
	{
		public int EventPostId { get; set; }
		public string EventPostName { get; set; }
		public DateTime PostTime { get; set; }
		public DateTime EventTime { get; set; }
		public DateTime EventDate { get; set; }
		public string EventPlace { get; set; }
		public string PostUserId { get; set; }
		public string PostUserName { get; set; }
		public string PostUserEmail { get; set; }
		public string EventUserId { get; set; }
		public string EventUserName { get; set; }
		public string EventUserEmail { get; set; }

		public CurrentEvents(
		int eventPostID,
		string eventPostName,
		DateTime postTime,
		DateTime eventTime,
		DateTime eventDate,
		string eventPlace,
		string postUserId,
		string postUserName,
		string postUserEmail,
		string eventUserId,
		string eventUserName,
		string eventUserEmail)
		{
			this.EventPostId = eventPostID;
			this.EventPostName = eventPostName;
			this.PostTime = postTime;
			this.EventTime = eventTime;
			this.EventDate = eventDate;
			this.EventPlace = eventPlace;
			this.PostUserId = postUserId;
			this.PostUserName = postUserName;
			this.PostUserEmail = postUserEmail;
			this.EventUserId = eventUserId;
			this.EventUserName = eventUserName;
			this.EventUserEmail = eventUserEmail;
		}
	}

	#endregion
}