import React from 'react'
import { CommentGet } from '../../Models/Comments'
import { commentPostAPI } from '../../Services/CommentService';
import StockCommentListItem from './StockCommentListItem/StockCommentListItem';

type Props = {
    comments: CommentGet[];
}

const StockCommentList = ({ comments }: Props) => {
  return (
    <div className="grid grid-cols-3 gap-4">
      {comments ? comments.map((comment) => {
        return (
          <div className="comment-box">
            <StockCommentListItem comment={comment} />
          </div>
        )
      }) : ""}
    </div>
  )
}

export default StockCommentList