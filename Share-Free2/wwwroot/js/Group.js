const myGroups_p = document.getElementsByClassName("myGroups");
const availableGroups_p = document.getElementsByClassName("availableGroups");

//const groupId_input = document.getElementById("groupId");
//const userId_input = document.getElementById("userId");

const userIdLeave_input = document.getElementById("userIdLeave");
//
const mygroups_div = document.getElementById("myGroups_div");
const availableGroup_div = document.getElementById("availableGroup_div"); 
//
function moveGroups(groupId) {
    const groupId_inputMove = document.getElementById("groupIdLeave_" + groupId);
    //remove from
    const mygroupdiv_div = document.getElementById("mygroupdiv_" + groupId);
    //add to
    const availablegroups_div = document.getElementById("availablegroupsdiv_" + groupId);


    console.log(groupId_inputMove.value);
    mygroups_div.removeChild(mygroupdiv_div);
    availablegroups_div.appendChild(mygroupdiv_div);

    
}

function leaveGroup(groupId) {
    const groupIdLeave_input = document.getElementById("groupIdLeave_" + groupId);

    var data = new FormData();
    data.append("groupIdLeave", groupIdLeave_input.value);
    data.append("userIdLeave", userIdLeave_input.value);

    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/Group/LeaveGroup");
    xhr.onreadystatechange = function () {

        if (xhr.status == 200) {
            console.log("Status: " + xhr.status)
            moveGroups(groupIdLeave_input.value);

        } else {
            alert("Please try again (Error message)");
        }
    }
    xhr.send(data);

    location.reload();
}



function joinGroup(groupId) {
    const groupId_input = document.getElementById("groupId_" + groupId);
    const userId_input = document.getElementById("userId");

    var data = new FormData();
    data.append("groupId", groupId_input.value);
    data.append("userId", userId_input.value);

    var xhr = new XMLHttpRequest();
    xhr.onload = function () {
        // reload div
        if (xhr.status == 200) {
        }
    };
    xhr.open("POST", "/Group/JoinGroup");
    
    xhr.send(data);
    location.reload();
}