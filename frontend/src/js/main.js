import Header from "./component/header";
import Footer from "./component/footer";
import Artists from "./component/Artists";
import Artist from"./component/Artist";
import ArtistProfile from "./component/artistProfile";
import AlbumList from "./component/albumList";
import ApiActions from "./API/apiActions";
import artists from "./component/Artists";

export default () =>
{
    Pagebuild();
};

// function Artistbuild(){
//     artistProfile();
//     albumList();
// }
function Pagebuild(){
    header();
    navArtists()
    // Artists();
    // albumList();
    footer();
};

function header(){
    const header = document.getElementById("header")
    header.innerHTML = Header();
}
function footer(){
    const footer = document.getElementById("footer")
    footer.innerHTML = Footer();
}
// function Artists(){
//     const Artists = document.getElementById("artist-list");
//     Artists.innerHTML = Artists();

// function artistProfile(){
//     const artistProfile = document.getElementById("artist-profile");
//     artistProfile.innerHTML = ArtistProfile();
// }
// function albumList(){
//     const albumList = document.getElementById("album-div");
//     ApiActions.getRequest("https://localhost:44386/api/albums", albums => {
//     albumList.innerHTML = AlbumList(albums);
//     });
// }
function navHome(){
    const homeButton = document.querySelector(".nav__home")
    homeButton.addEventListener('click', function(){
        document.querySelector("#app").innerHTML = Home()
    });
}
function navArtists(){
    const artistsButton= document.querySelector(".nav__artists");
    const app = document.querySelector("#app");
    artistsButton.addEventListener("click", function(){
        apiActions.getRequest("https://localhost:44305/api/artists", artists => {
            document.querySelector("#app").innerHTML = Artists(artists);
        });
    });
    app.addEventListener('click', function(){
        if(event.target.classList.contains("add-artist__submit")){
            const artist = event.target.parentElement.querySelector(
                ".add-artist__artistName"
            ).value;
            console.log(artist);
            apiActions.postRequest("https://localhost:44386/api/artists",
            {
                name: artist
            },
            artists => {
                console.log(artists);
                app.innerHTML = Artists(artists);
             });
        }
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("delete-artist__submit")){
            const artistID = event.target.parentElement.querySelector(".artist__id").value;
            console.log("delete" + artistID)
            apiActions.deleteRequest(`https://localhost:44386/api/artists/${artistID}`,
            artists => {
                app.innerHTML = Artists(artists);
            })
        }
    });
    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-artist__submit")){
            const artistID = event.target.parentElement.querySelector(".artist__id").value;
            console.log("edit" + artistID);
            apiActions.getRequest(
                `https://localhost:44386/api/artists/${artistID}`,
                artist => {
                    app.innerHTML= Artist(artist);
                })
        }
    })
    app.addEventListener("click", function(){
        if(event.target.classList.contains("update-artist__submit")){
            const artistID = event.target.parentElement.querySelector(
                ".update-artist__id"
            ).value;
            const artistName = event.target.parentElement.querySelector(".update-artist__name"
            ).value;
            const artistData = {
                id: artistID,
                name: artistName
            }
            apiActions.putRequest(`https://localhost:44386/api/artists/${artistID}`,
            artistData,
            artists => {
                app.innerHTML = Artists(artists)
            }
            );
        }
    })
}