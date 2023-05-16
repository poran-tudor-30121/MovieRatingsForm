﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieConsoleAppClient.MovieServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Movie", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class Movie : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DirectorField;
        
        private int YearField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Director {
            get {
                return this.DirectorField;
            }
            set {
                if ((object.ReferenceEquals(this.DirectorField, value) != true)) {
                    this.DirectorField = value;
                    this.RaisePropertyChanged("Director");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int Year {
            get {
                return this.YearField;
            }
            set {
                if ((this.YearField.Equals(value) != true)) {
                    this.YearField = value;
                    this.RaisePropertyChanged("Year");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MovieServiceReference1.MovieServiceSoap")]
    public interface MovieServiceSoap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponse HelloWorld(MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponse> HelloWorldAsync(MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest request);
        
        // CODEGEN: Generating message contract since element name GetMoviesResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMovies", ReplyAction="*")]
        MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponse GetMovies(MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetMovies", ReplyAction="*")]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponse> GetMoviesAsync(MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest request);
        
        // CODEGEN: Generating message contract since element name Title from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddMovie", ReplyAction="*")]
        MovieConsoleAppClient.MovieServiceReference1.AddMovieResponse AddMovie(MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddMovie", ReplyAction="*")]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.AddMovieResponse> AddMovieAsync(MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest request);
        
        // CODEGEN: Generating message contract since element name title from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchMovies", ReplyAction="*")]
        MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponse SearchMovies(MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SearchMovies", ReplyAction="*")]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponse> SearchMoviesAsync(MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMoviesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMovies", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequestBody Body;
        
        public GetMoviesRequest() {
        }
        
        public GetMoviesRequest(MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetMoviesRequestBody {
        
        public GetMoviesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetMoviesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetMoviesResponse", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponseBody Body;
        
        public GetMoviesResponse() {
        }
        
        public GetMoviesResponse(MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetMoviesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.Movie[] GetMoviesResult;
        
        public GetMoviesResponseBody() {
        }
        
        public GetMoviesResponseBody(MovieConsoleAppClient.MovieServiceReference1.Movie[] GetMoviesResult) {
            this.GetMoviesResult = GetMoviesResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddMovieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddMovie", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.AddMovieRequestBody Body;
        
        public AddMovieRequest() {
        }
        
        public AddMovieRequest(MovieConsoleAppClient.MovieServiceReference1.AddMovieRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddMovieRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Title;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Director;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int Year;
        
        public AddMovieRequestBody() {
        }
        
        public AddMovieRequestBody(string Title, string Director, int Year) {
            this.Title = Title;
            this.Director = Director;
            this.Year = Year;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddMovieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddMovieResponse", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.AddMovieResponseBody Body;
        
        public AddMovieResponse() {
        }
        
        public AddMovieResponse(MovieConsoleAppClient.MovieServiceReference1.AddMovieResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class AddMovieResponseBody {
        
        public AddMovieResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchMoviesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchMovies", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequestBody Body;
        
        public SearchMoviesRequest() {
        }
        
        public SearchMoviesRequest(MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchMoviesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string title;
        
        public SearchMoviesRequestBody() {
        }
        
        public SearchMoviesRequestBody(string title) {
            this.title = title;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SearchMoviesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SearchMoviesResponse", Namespace="http://tempuri.org/", Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponseBody Body;
        
        public SearchMoviesResponse() {
        }
        
        public SearchMoviesResponse(MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SearchMoviesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public MovieConsoleAppClient.MovieServiceReference1.Movie[] SearchMoviesResult;
        
        public SearchMoviesResponseBody() {
        }
        
        public SearchMoviesResponseBody(MovieConsoleAppClient.MovieServiceReference1.Movie[] SearchMoviesResult) {
            this.SearchMoviesResult = SearchMoviesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MovieServiceSoapChannel : MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MovieServiceSoapClient : System.ServiceModel.ClientBase<MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap>, MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap {
        
        public MovieServiceSoapClient() {
        }
        
        public MovieServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MovieServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MovieServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponse MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.HelloWorld(MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequestBody();
            MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponse retVal = ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponse> MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.HelloWorldAsync(MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.HelloWorldRequestBody();
            return ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponse MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.GetMovies(MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest request) {
            return base.Channel.GetMovies(request);
        }
        
        public MovieConsoleAppClient.MovieServiceReference1.Movie[] GetMovies() {
            MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequestBody();
            MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponse retVal = ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).GetMovies(inValue);
            return retVal.Body.GetMoviesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponse> MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.GetMoviesAsync(MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest request) {
            return base.Channel.GetMoviesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.GetMoviesResponse> GetMoviesAsync() {
            MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.GetMoviesRequestBody();
            return ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).GetMoviesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MovieConsoleAppClient.MovieServiceReference1.AddMovieResponse MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.AddMovie(MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest request) {
            return base.Channel.AddMovie(request);
        }
        
        public void AddMovie(string Title, string Director, int Year) {
            MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.AddMovieRequestBody();
            inValue.Body.Title = Title;
            inValue.Body.Director = Director;
            inValue.Body.Year = Year;
            MovieConsoleAppClient.MovieServiceReference1.AddMovieResponse retVal = ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).AddMovie(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.AddMovieResponse> MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.AddMovieAsync(MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest request) {
            return base.Channel.AddMovieAsync(request);
        }
        
        public System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.AddMovieResponse> AddMovieAsync(string Title, string Director, int Year) {
            MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.AddMovieRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.AddMovieRequestBody();
            inValue.Body.Title = Title;
            inValue.Body.Director = Director;
            inValue.Body.Year = Year;
            return ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).AddMovieAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponse MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.SearchMovies(MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest request) {
            return base.Channel.SearchMovies(request);
        }
        
        public MovieConsoleAppClient.MovieServiceReference1.Movie[] SearchMovies(string title) {
            MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequestBody();
            inValue.Body.title = title;
            MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponse retVal = ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).SearchMovies(inValue);
            return retVal.Body.SearchMoviesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponse> MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap.SearchMoviesAsync(MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest request) {
            return base.Channel.SearchMoviesAsync(request);
        }
        
        public System.Threading.Tasks.Task<MovieConsoleAppClient.MovieServiceReference1.SearchMoviesResponse> SearchMoviesAsync(string title) {
            MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest inValue = new MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequest();
            inValue.Body = new MovieConsoleAppClient.MovieServiceReference1.SearchMoviesRequestBody();
            inValue.Body.title = title;
            return ((MovieConsoleAppClient.MovieServiceReference1.MovieServiceSoap)(this)).SearchMoviesAsync(inValue);
        }
    }
}
