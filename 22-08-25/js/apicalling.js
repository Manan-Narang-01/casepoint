const api_url = 'https://dummyjson.com/posts';

        function loadpost() {
            $.get(api_url, function (data) {
                $("#postTable").empty();
                data.posts.forEach(post => {
                    $("#postTable").append(`
                        <tr>
                            <td>${post.id}</td>
                            <td>${post.body}</td>
                            <td>${post.title}</td>
                            <td><button id="edit" onclick="editPost(${post.id})">Edit</button></td>
                            <td><button id="delete" onclick="deletePost(${post.id})">Delete</button></td>
                        </tr>
                    `);
                });
            });
        }

        $("#createbutton").click(function () {
            const title = $("#title").val();
            const body = $("#body").val();
            const id = $("#pid").val();

            if(id){
                $.ajax({
                url: api_url + "/" + id,
                type: "PUT",
                data: JSON.stringify({ title, body }),
                contentType: "application/json; charset=UTF-8",
                success: function (updatepost) {
                    alert("Updated Post Id: " + updatepost.id);
                    loadpost();
                    $("#title,#body,#pid").val("");
                    
                }
            });

            }
            else{
                
                $.ajax({
                url: api_url + "/add",
                type: "POST",
                data: JSON.stringify({ title, body, userId: 1 }),
                contentType: "application/json; charset=UTF-8",
                success: function (newpost) {
                    alert("Created Post Id: " + newpost.id);
                    loadpost();
                    $("#title,#body").val("");
                }
            });

            }
        });

        function editPost(id) {
            $.get(api_url + "/" + id, function (post) {
                $("#pid").val(post.id);
                $("#title").val(post.title);
                $("#body").val(post.body);
            });
        }

        function deletePost(id) {
            $.ajax({
                url: api_url + "/" + id,
                type: "DELETE",
                success: function () {
                    alert("Deleted Post ID: " + id);
                    loadpost();
                }
            });
        }

        $(document).ready(function () {
            loadpost();
        });