import Header from "./component/header";
import Footer from "./component/footer";
import ArtistList from "./component/artistList";
import ArtistProfile from "./component/artistProfile";
import AlbumList from "./component/albumList";
import ApiActions from "./API/apiActions";

export default () =>
{
    Pagebuild();
};

function Artistbuild(){
    artistProfile();
    albumList();
}
function Pagebuild(){
    header();
    artistProfile();
    artistList();
    footer();
    navAlbum();
};

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header();
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer();
}
function artistList(){
    const artistList = document.getElementById("artist-list");
    artistList.innerHTML = ArtistList();
}
function artistProfile(){
    const artistProfile = document.getElementById("artist-profile");
    artistProfile.innerHTML = ArtistProfile();
}
function albumList(){
    const albumList = document.getElementById("album-div");
   
 
          apiActions.getRequest("https://localhost:44327/api/todos", toDos => {
            albumList.innerHTML = AlbumList();
          });
    
}



function navAlbum(){
    const albumButton = document.querySelector(".album-div");
    // albumButton.addEventListener("click", function(){
        ApiActions.getRequest("https://localhost:44386/api/albums", albums => {
            albumButton.innerHTML = Album(albums);
        });
    // });
    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("add-album__submit")) {
            const album = event.target.parentElement.querySelector(
                ".add-album__albumName"
            ).value;
            console.log(album);
            ApiActions.postRequest("https://localhost:44386/api/albums",
            {
                name: album
            },
            albums =>{
                console.log(albums);
                document.querySelector("#app").innerHTML = Album(albums)
            })
        }
    })
}



