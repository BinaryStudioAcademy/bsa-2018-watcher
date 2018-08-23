import { Component, OnInit, ViewChild } from '@angular/core';
import { FormControl, FormBuilder, Validators } from '@angular/forms';
import { UserService } from '../../core/services/user.service';
import { AuthService } from '../../core/services/auth.service';
import { User } from '../../shared/models/user.model';
import { ToastrService } from '../../core/services/toastr.service';
import { ImageCropperComponent, CropperSettings } from 'ngx-img-cropper';
import { PathService } from '../../core/services/path.service';

@Component({
  selector: 'app-user-profile',
  templateUrl: './user-profile.component.html',
  styleUrls: ['./user-profile.component.sass']
})
export class UserProfileComponent implements OnInit {
  data: any;
  photoUrl: string;
  photoType: string;
  private isUpdating: Boolean = false;

  @ViewChild('cropper', undefined)

  cropper: ImageCropperComponent;

  cropperSettings: CropperSettings;
  display: Boolean = false;

  constructor(private fb: FormBuilder,
    private userService: UserService,
    private authService: AuthService,
    private toastrService: ToastrService,
    private pathService: PathService) {

    this.cropperSettings = new CropperSettings();
    this.cropperSettings.width = 200;
    this.cropperSettings.height = 200;
    this.cropperSettings.minWidth = 100;
    this.cropperSettings.minHeight = 100;
    this.cropperSettings.croppedWidth = 70;
    this.cropperSettings.croppedHeight = 70;
    this.cropperSettings.canvasWidth = 400;
    this.cropperSettings.canvasHeight = 400;
    this.cropperSettings.noFileInput = true;
    this.cropperSettings.preserveSize = true;

    this.data = {};
    }

  public user: User;
  private userId: string;

  public userForm = this.fb.group({
    displayName: new FormControl({ value: '', disabled: true }, Validators.required),
    firstName: new FormControl({ value: '', disabled: true }, Validators.required),
    lastName: new FormControl({ value: '', disabled: true }, Validators.required),
    bio: new FormControl({ value: '', disabled: true })
  });

  ngOnInit() {
    this.authService.currentUser.subscribe(
      (userData) => {
        this.user = { ...userData };
        this.userId = userData.id;
        this.setUserData();
      }
    );
  }

  setUserData(): void {
    Object.keys(this.userForm.controls).forEach(field => {
      const control = this.userForm.get(field);
      control.setValue(this.user[field]);
      control.enable();
      this.photoUrl = this.pathService.convertToUrl(this.user.photoURL);
    });

    this.userForm.valueChanges.subscribe(value => {
      Object.keys(this.userForm.controls).forEach(field => {
        this.user[field] = this.userForm.get(field).value;
      });
    });
  }

  onImageSelected(upload) {
    const image: any = new Image();
    const reader: FileReader = new FileReader();
    const that = this;
    this.photoType = upload[0].type;
    reader.onloadend = (eventLoad: any) => {
      image.src = eventLoad.target.result;
      that.cropper.setImage(image);
      this.display = true;
    };
    reader.readAsDataURL(upload[0]);
    upload.splice(0, upload.length);
  }

  onCropCancel() {
    this.photoType = '';
    this.display = false;
  }

  onCropSave() {
    this.user.photoURL = this.data.image;
    this.user.photoType = this.photoType;
    this.photoUrl = this.data.image;
    this.display = false;
  }

  onSubmit() {
    if (this.userForm.valid) {
      this.isUpdating = true;
      this.userService.update(this.userId, this.user).subscribe(value => {

        this.authService.updateCurrentUser(this.user);
        this.toastrService.success('Profile was updated');
        this.isUpdating = false;
      },
        err => {
          this.toastrService.error('Profile was not updated');
          this.isUpdating = false;
        });
    } else {
      Object.keys(this.userForm.controls).forEach(field => {
        const control = this.userForm.get(field);
        control.markAsDirty({ onlySelf: true });
      });
    }
  }
}
