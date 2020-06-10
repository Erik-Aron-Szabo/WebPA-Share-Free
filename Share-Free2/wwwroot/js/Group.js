

function leaveGroup() {

}


function joinGroup() {
    const groupId_input = document.getElementById("groupId");
    const userId_input = document.getElementById("userId");

    var data = new FormData();
    data.append("groupId", groupId_input.value);
    data.append("userId", userId_input.value);

    var xhr = new XMLHttpRequest();
    xhr.open("POST", "/Group/JoinGroup");
    xhr.send(data);
}