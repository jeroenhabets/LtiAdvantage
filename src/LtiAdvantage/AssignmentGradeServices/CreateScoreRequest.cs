﻿namespace LtiAdvantage.AssignmentGradeServices
{
    /// <summary>
    /// Represents a create score request.
    /// </summary>
    public class CreateScoreRequest
    {
        /// <summary>
        /// Initialize a new instance of the class.
        /// </summary>
        public CreateScoreRequest(string contextId, string id, Score score)
        {
            ContextId = contextId;
            Id = id;
            Score = score;
        }

        /// <summary>
        /// Get or set the context id.
        /// </summary>
        public string ContextId { get; set; }

        /// <summary>
        /// Get or set the line item Id.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// The score.
        /// </summary>
        public Score Score { get; set; }
    }
}