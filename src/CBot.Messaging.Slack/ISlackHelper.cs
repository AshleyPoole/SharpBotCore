﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using CBot.Messaging.Domain;

using SlackConnector;
using SlackConnector.Models;

namespace CBot.Messaging.Slack
{
	public interface ISlackHelper
	{
		Task<IncomingMessage> ConvertMessageToIncomingMessageType(SlackMessage slackMessage, Guid traceId, ISlackConnection connection);

		Task<SlackChatHub> GetChatHub(ResponseMessage responseMessage, ISlackConnection connection);

		IList<SlackAttachment> ConvertAttachmentsToSlackAttachments(IEnumerable<Attachment> attachments);
	}
}
