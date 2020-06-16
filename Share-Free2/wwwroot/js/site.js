function moveComments(commentId) {
    //const comment_div = document.getElementById("commentdiv_" + commentId);
    //list_comment_div.removeChild(comment_div);
}

function modifyPostForm(postId) {
    const modifyPost_div = document.getElementById("modifyPostDiv_" + postId);
    modifyPost_div.classList.remove("hidden");
}

function modifyPost(postId) {
    const modifyPostId_input = document.getElementById("modifyPostId_" + postId);
    const modifyPostTitle_input = document.getElementById("modifyPostTitle_" + postId);
    const modifyPostDescription_input = document.getElementById("modifyPostDescription_" + postId);


    var data = new FormData();
    data.append("modifyPostId", modifyPostId_input.value);
    data.append("modifyPostTitle", modifyPostTitle_input.value);
    data.append("modifyPostDescription", modifyPostDescription_input.value);


    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/Post/ModifyPost");
    xhr.onloadend = function () {
        var response = this.responseText;
        console.log(response);
        location.reload();
    }
    xhr.send(data);


}

function test(postId) {
    const createComment_form = document.getElementById("createCommentForm_" + postId);
    createComment_form.classList.remove("hidden2");
}

function createPost() {
    const createPost_form = document.getElementById("createPostForm");
    createPost_form.classList.remove("hidden");
}


// Im stuck! How to get the freshly created post?
function getCreatePost() {

    var xhr = new XMLHttpRequest();
    xhr.open("GET", "/Post/CreatePost");
    xhr.onload = function () {

    }
    xhr.send();
    
}

function postCreatePost() {
    const getUsernamePost = document.getElementById("getUsernamePost");

    //DOM - HTML create it here first

    const postContainer = document.getElementById("post_container");



    //Database
    var data = new FormData();
    data.append("username", getUsernamePost.value);

    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/Post/CreatePost");
    xhr.onload = function () {
        var newPost = JSON.parse(this.responseText);
        // a fenti response-bol kell kibogarasznom az post.Id, post.Title, post.Username etc.

        // aztan adjam at ezeket argument-kent a functionba

        //A functionba, amelyikkel letre fogom hozni a DOM-ban levo dolgokat (div, input, ilyesmiket)

    };

    xhr.send(data);
}

function deletePost(postId) {
    const postId_input = document.getElementById("postId_" + postId);


    // deleting DIV
    const postDiv = document.getElementById("postdiv_" + postId);


    var data = new FormData();
    data.append("postId", postId_input.value);

    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/Post/DeletePost");
    
    xhr.onload = function () {
        postDiv.parentElement.removeChild(postDiv);
    }

    xhr.send(data);
    


}

function modifyComment(commentId) {
    const modifyComment_form = document.getElementById("modifyCommentForm_" + commentId);
    modifyComment_form.classList.remove("hidden2");
}

function deleteComment(commentId) {
    //const commentUsername = document.getElementById("getCommentUsername");
    const commentId_input = document.getElementById("getCommentId_" + commentId);

    // comment div
    const comment_div = document.getElementById("commentdiv_" + commentId);


    var data = new FormData();
    //data.append("username", commentUsername.value);
    data.append("commentId", commentId_input.value);

    var xhr = new XMLHttpRequest();
    oad = function () {

        comment_div.parentElement.removeChild(comment_div);
    }
    xhr.open("POST", "/Comment/DeleteComment");

    xhr.send(data);
}

