// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.



// Code to refresh posts
const divCreatePost = document.querySelector(".createpost");

function refreshPosts() {
    
}

// comment



function deleteComment() {
    //getUsername 
    const getCommentId = document.getElementById("getCommentId");
    const getCommentDate = document.getElementById("getCommentDate");
    const commentUsername = document.getElementById("getCommentUsername");
    var data = new FormData();
    data.append("username", commentUsername.value);
    data.append("commentId", getCommentId.value);
    //data.append("commentDate", getCommentDate.value);

    var xhr = new XMLHttpRequest();
    xhr.open("DELETE", "/Comment/DeleteComment");
    xhr.send(data);

}