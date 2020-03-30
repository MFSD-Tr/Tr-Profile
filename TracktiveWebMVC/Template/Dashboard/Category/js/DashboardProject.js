var Nav = 'Open';

function NavOpenClose() {
    
    if (Nav === 'Open') {

        document.getElementById("mySidebar").style.width = "300px";
        document.getElementById("main").style.marginLeft = "300px";

        Nav = 'Close';

        document.getElementById("projectListBtnId").innerHTML = 'dgdgdg';

        document.getElementById("projectListBtnId").className = 'fa fa-arrow-circle-left fa-3x';

    }
    else {

        document.getElementById("mySidebar").style.width = "0";
        document.getElementById("main").style.marginLeft = "0";

        Nav = 'Open';

        document.getElementById("projectListBtnId").innerHTML = '☰ ' + Nav + ' Projects';

    }

}

function ProjectDashboardLoad(projectId) {
    alert("ff");
    $("#main").load("http://localhost:55852/DashBoard/CategoryDashBoard/?categoryId=" + projectId);

}

