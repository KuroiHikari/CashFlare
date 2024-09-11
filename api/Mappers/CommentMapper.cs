using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.DTOs.Comment;
using api.Models;

namespace api.Mappers
{
    public static class CommentMapper
    {
        public static CommentDTO ToCommentDTO(this Comment commentModel)
        {
            return new CommentDTO
            {
                ID = commentModel.ID,
                Title = commentModel.Title,
                Content = commentModel.Content,
                CreatedOn = commentModel.CreatedOn,
                CreatedBy = commentModel.AppUser.UserName,
                StockID = commentModel.StockID
            };
        }

        public static Comment ToCommentFromCreate(this CreateCommentDTO commentDTO, int stockID)
        {
            return new Comment
            {
                Title = commentDTO.Title,
                Content = commentDTO.Content,
                StockID = stockID
            };
        }

        public static Comment ToCommentFromUpdate(this UpdateCommentRequestDTO updateDTO)
        {
            return new Comment
            {
                Title = updateDTO.Title,
                Content = updateDTO.Content
            };
        }
    }
}